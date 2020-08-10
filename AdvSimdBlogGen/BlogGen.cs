using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

namespace AdvSimdBlogGen
{
    public partial class AdvSimdBlogGen
    {
        private static StringBuilder methodDefBuilder = new StringBuilder();
        private static StringBuilder methodCallBuilder = new StringBuilder();
        private static StringBuilder jitAsmBuilder = new StringBuilder();
        private static HashSet<string> uniqueArgs = new HashSet<string>();
        private static List<string> tocBuilder = new List<string>();
        private static Dictionary<string, string> globalTocBuilder = new Dictionary<string, string>();
        private static Dictionary<string, List<Tuple<string, SeparatedSyntaxList<ParameterSyntax>>>> advSimdMethods = new Dictionary<string, List<Tuple<string, SeparatedSyntaxList<ParameterSyntax>>>>();
        private static Dictionary<string, List<Tuple<string, SeparatedSyntaxList<ParameterSyntax>>>> arm64Methods = new Dictionary<string, List<Tuple<string, SeparatedSyntaxList<ParameterSyntax>>>>();
        private static bool shouldGenerateCsv = false;

        public static void Main(string[] args)
        {
            string dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string genCsProjPath = Path.Combine(dirName, "..", "..", "..");
            string generatedCsProjPath = Path.Combine(dirName, "..", "..", "..", "..", "AdvSimdGenerated");
            PopulateMethods();
            GenerateBlogContents();
            WriteGeneratedCodeToFile(Path.Combine(generatedCsProjPath, "AdvSimdGenerated.cs"));
            //SplitGeneratedBlog();
            PrintVarsAndMethodNames();
            Console.WriteLine("done");
        }

        internal static void SplitGeneratedBlog()
        {
            string dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string blogFileName = "2018-01-01-Test";
            string blogFileFullPath = Path.Combine(dirName, blogFileName + ".md");
            Console.WriteLine($"Press enter to split the '{blogFileFullPath}' blog.");
            Console.ReadLine();
            string[] blogContents = File.ReadAllLines(blogFileFullPath);
            StringBuilder blogBuilder = new StringBuilder();
            int partId = 1;
            foreach (string line in blogContents)
            {
                string blogLine = line;
                if ("START---END" == blogLine)
                {
                    blogLine = "---";
                    if (blogBuilder.Length > 0)
                    {
                        string fileName = $"{blogFileName}-Part{partId++}.md";
                        File.WriteAllText(Path.Combine(dirName, fileName), blogBuilder.ToString());
                        blogBuilder.Clear();
                    }
                }
                blogBuilder.AppendLine(blogLine);
            }
            // leftover
            if (blogBuilder.Length > 0)
            {
                string fileName = $"{blogFileName}-Part{partId++}.md";
                File.WriteAllText(Path.Combine(dirName, fileName), blogBuilder.ToString());
            }
        }

        internal static void PrintVarsAndMethodNames()
        {
            foreach (string uniqueArg in uniqueArgs)
            {
                Console.WriteLine("var " + uniqueArg + " = Vector128.Create(1);");
            }

            Console.WriteLine("set COMPlus_JitDisasm=" + jitAsmBuilder.ToString());
        }

        internal static void GenerateBlogContents()
        {
            HashSet<string> methodsDone = new HashSet<string>();

            // Process AdvSimd methods
            foreach (string methodName in advSimdMethods.Keys)
            {
                GenerateCodeForMethod(methodName, true);
                Debug.Assert(methodsDone.Add(methodName), $"{methodName} already present.");
            }

            // Process AdvSimd.Arm64 methods
            foreach (string methodName in arm64Methods.Keys)
            {
                if (methodsDone.Contains(methodName))
                {
                    continue;
                }
                GenerateCodeForMethod(methodName, false);
            }

            string toc = string.Join(", ", tocBuilder);
            // update previous value
            globalTocBuilder.Add($"PART-{sectionCount - 1}-TOC", toc);

        }

        private static void WriteGeneratedCodeToFile(string fileName)
        {
            string classContents = string.Format(classTemplate, methodDefBuilder.ToString(), methodCallBuilder.ToString());
            foreach(var tocContents in globalTocBuilder)
            {
                classContents = classContents.Replace(tocContents.Key, tocContents.Value);
            }
            File.WriteAllText(fileName, classContents.ToString());
        }

        private static void GenerateCodeForMethod(string methodName, bool isForAdvSimd)
        {
            if (((count - 1) % 60) == 0)
            {
                count = 1;
                string placeHolder = $"PART-{sectionCount}-TOC";
                string toc = string.Join(", ", tocBuilder);
                if (sectionCount > 1)
                {
                    // update previous value. Skip adding for 1st because no toc by that time.
                    globalTocBuilder.Add($"PART-{sectionCount - 1}-TOC", toc);
                }
                methodCallBuilder.AppendLine(string.Format(header, sectionCount++, placeHolder));
                tocBuilder.Clear();
            }
            var details = isForAdvSimd ? advSimdMethods[methodName].First() : arm64Methods[methodName].First();
            string signature = details.Item1;
            string testMethodName = methodName + "Test";
            string dummyTestMethodName = "Dummy_" + methodName + "Test";
            string testMethodSig = signature.Replace(methodName, testMethodName);
            string dummyTestMethodSig = signature.Replace(methodName, dummyTestMethodName);
            var parameters = details.Item2;

            // TOC
            tocBuilder.Add(string.Format("[{0}](#{1}-{2})", methodName, count, methodName.ToLower()));

            // References
            string advsimdReference = "[here](" + string.Format(advSimdRefTemplate, methodName.ToLower()) + ")";
            string arm64Reference = "[here](" + string.Format(arm64RefTemplate, methodName.ToLower()) + ")";

            // Overloads
            StringBuilder overloadBuilder = new StringBuilder();
            var otherOverloads = isForAdvSimd ? advSimdMethods[methodName].Skip(1) : arm64Methods[methodName].Skip(1);
            if (otherOverloads.Count() > 0)
            {
                overloadBuilder.AppendLine("// class System.Runtime.Intrinisics.AdvSimd" + (isForAdvSimd ? "" : ".Arm64"));
                overloadBuilder.Append(string.Join(Environment.NewLine, otherOverloads.Select(sm => sm.Item1)));
            }

            if (isForAdvSimd)
            {
                // Process AdvSimd.Arm64 methods, if present
                if (arm64Methods.ContainsKey(methodName))
                {
                    var similarMethods = arm64Methods[methodName];
                    overloadBuilder.AppendLine();
                    overloadBuilder.AppendLine();
                    overloadBuilder.AppendLine("// class System.Runtime.Intrinisics.AdvSimd.Arm64");
                    overloadBuilder.Append(string.Join(Environment.NewLine, similarMethods.Select(sm => sm.Item1)));

                    advsimdReference += " and " + arm64Reference;
                }
            }
            else
            {
                advsimdReference = arm64Reference; // only reference would be from ARM64 namespace.
            }

            if (overloadBuilder.Length > 0)
            {
                StringBuilder headerOfOverloadSection = new StringBuilder();
                headerOfOverloadSection.AppendLine("Similar APIs that operate on different sizes:");
                headerOfOverloadSection.AppendLine();
                headerOfOverloadSection.AppendLine("```csharp");

                overloadBuilder.Insert(0, headerOfOverloadSection.ToString());
                overloadBuilder.AppendLine();
                overloadBuilder.AppendLine("```");
            }

            // jitasm
            jitAsmBuilder.Append(testMethodName).Append(" ");

            // method call
            List<string> args = new List<string>();
            List<string> argsValueToPrint = new List<string>() { $"\"Performs '{methodName}' operation.\"" };
            StringBuilder argsValuePrintBuilder = new StringBuilder();
            Dictionary<string, int> argsTracker = new Dictionary<string, int>();
            int argCount = 1;
            bool isUnsafe = false;
            bool isVoid = signature.StartsWith("void ");
            bool isBytePtr = false, isIntPtr = false;
            foreach (var p in parameters)
            {
                bool isPtr = p.Type.ToString().Contains("*");
                if (isPtr)
                {
                    isBytePtr = p.Type.ToString().Contains("byte");
                    isIntPtr = p.Type.ToString().Contains("int");
                }
                string normalizedType = p.Type.ToString().Replace("<", string.Empty).Replace(">", string.Empty).Replace("*", "Ptr");
                
                int id = 0;
                if (!argsTracker.ContainsKey(normalizedType))
                {
                    argsTracker.Add(normalizedType, id);
                }

                string uniqueArgName = normalizedType + "_" + argsTracker[normalizedType];
                args.Add(uniqueArgName);
                argsValueToPrint.Add(isPtr ? "\"<address>\"" : uniqueArgName);
                uniqueArgs.Add(uniqueArgName); // Track so we can create only these many args for all the methods.
                argsTracker[normalizedType] += 1; // increment the id.

                argsValuePrintBuilder.AppendLine(string.Format(argValuePrintTemplate, p.Identifier.Text, "{" + argCount++ + "}"));
                isUnsafe |= isPtr;
            }

            // method defintion

            var methodParams = string.Join(", ", parameters.Select(p => p.Identifier.Text));
            string returnStatement = string.Format("{0}.{1}({2})", isForAdvSimd ? "AdvSimd" : "AdvSimd.Arm64", methodName, methodParams);
            if (!isVoid)
            {
                returnStatement = "return " + returnStatement;
                argsValuePrintBuilder.AppendLine(string.Format(argValuePrintTemplate, "Result", "{" + argCount + "}"));
                //argsValueToPrint.Add(methodName + "Result"); // result to be passed to Console.WriteLine
                argsValueToPrint.Add("apiResult"); // result to be passed to Console.WriteLine
            }

            string methodDef = string.Format(methodDefinitionTemplate, returnStatement, testMethodSig, isUnsafe ? "unsafe" : string.Empty);
            string dummyMethodDef = string.Format(methodDefinitionTemplate, returnStatement, dummyTestMethodSig, isUnsafe ? "unsafe" : string.Empty);
            methodDefBuilder.Append(dummyMethodDef);
            methodDefBuilder.Append(methodAttribute);
            methodDefBuilder.AppendLine(methodDef);
            methodDefBuilder.AppendLine();

            string result = methodName;
            string dummyResult = isVoid ? methodName : string.Format("var {0}Result = Dummy_{0}", methodName);

            string dummyMethodCall;
            if (isVoid)
            {
                dummyMethodCall = string.Format(methodCallTemplate, dummyResult, string.Join(", ", args), string.Empty);
            }
            else
            {
                dummyMethodCall = string.Format(methodCallTemplate, dummyResult, string.Join(", ", args), "apiResult = " + (methodName + "Result.ToString()") + ";");
            }


            string methodCall = string.Format(methodCallTemplate, result, string.Join(", ", args), string.Empty);
            if (isUnsafe)
            {
                if (isBytePtr)
                {
                    methodCallBuilder.AppendLine("fixed (byte* bytePtr_0 = byteArray)");
                    methodCallBuilder.AppendLine("{");
                }
                if (isIntPtr)
                {
                    methodCallBuilder.AppendLine("fixed (int* intPtr_0 = intArray)");
                    methodCallBuilder.AppendLine("{");
                }
            }

            // Print method definition and result
            string methodDefPrint = string.Format(methodDefPrintTemplate, 
                returnStatement, // 0
                testMethodSig, // 1
                argsValuePrintBuilder.ToString(),  // 2
                string.Join(", ", argsValueToPrint), // 3
                count, // 4
                methodName, // 5
                signature, // 6
                overloadBuilder.ToString(), // 7
                advsimdReference, // 8
                (count == 1) ?  string.Empty : sectionSep // 9
                );

            methodCallBuilder.AppendLine(dummyMethodCall);
            methodCallBuilder.AppendLine(methodDefPrint);
            methodCallBuilder.AppendLine(methodCall);

            if (isUnsafe)
            {
                if (isBytePtr)
                {
                    methodCallBuilder.AppendLine("}");
                }
                if (isIntPtr)
                {
                    methodCallBuilder.AppendLine("}");
                }
            }
            if (shouldGenerateCsv)
            {
                argsValueToPrint.Insert(0, "\"Performs '" + methodName + "' operation\"");
                argsValueToPrint.Insert(0, "\"" + methodName + "\"");
                methodCallBuilder.AppendLine(string.Format(LogInCsvTemplate, string.Join(", ", argsValueToPrint)));
            }
            methodCallBuilder.AppendLine("// ----------------------------------------------------------------");
            count++;
        }

        internal static void PopulateMethods()
        {
            // https://github.com/dotnet/runtime/blob/master/src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/Arm/AdvSimd.cs
            string contents = File.ReadAllText(@"D:\git\runtime\src\libraries\System.Private.CoreLib\src\System\Runtime\Intrinsics\Arm\AdvSimd.cs");
            SyntaxTree tree = CSharpSyntaxTree.ParseText(contents);
            var members = tree.GetRoot().DescendantNodes().OfType<MemberDeclarationSyntax>();
            foreach (var member in members)
            {
                var method = member as MethodDeclarationSyntax;
                if (method != null)
                {
                    string className = ((Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax)method.Parent).Identifier.ValueText;
                    string methodName = method.Identifier.Text;
                    var tableToUse = className == "Arm64" ? arm64Methods : advSimdMethods;

                    var parameters = method.ParameterList.Parameters;
                    string parametersSig = string.Join(", ", parameters.Select(p => p.ToString()));
                    var returnType = method.ReturnType.ToString();
                    if (!tableToUse.ContainsKey(methodName))
                    {
                        tableToUse[methodName] = new List<Tuple<string, SeparatedSyntaxList<ParameterSyntax>>>();
                    }

                    string signature = $"{returnType} {methodName}({parametersSig})";

                    tableToUse[methodName].Add(Tuple.Create(signature, parameters));
                }
            }
        }
    }
}
