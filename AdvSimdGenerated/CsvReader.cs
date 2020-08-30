using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Reflection;

public partial class AdvSimdMethods
{
    private static StringBuilder csvGenerator = new StringBuilder();
    private static Dictionary<string, List<string>> csvValues = null;

    internal static void ReadCsv()
    {
        Assembly asm = Assembly.GetExecutingAssembly();
        using (Stream rsrcStream = asm.GetManifestResourceStream(asm.GetName().Name + ".data.csv"))
        {
            using (StreamReader sRdr = new StreamReader(rsrcStream))
            {
                //For instance, gets it as text
                string[] csvEntries = sRdr.ReadToEnd().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                csvValues = new Dictionary<string, List<string>>();
                foreach (string csvEntry in csvEntries)
                {
                    var methodEntry = csvEntry.Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
                    csvValues[methodEntry[0]] = methodEntry.Skip(1).ToList();
                }
            }
        }
    }

    /// <summary>
    /// Log an entry in csv
    /// </summary>
    /// <param name="entries"></param>
    private static void LogInCsv(params object[] entries)
    {
        string entry = string.Join("|", entries.Select(e => e.ToString()));
        csvGenerator.AppendLine(entry);
    }

    /// <summary>
    /// Gets the value from csv at <paramref name="index"/> for <paramref name="methodName"/> and returns. 
    /// If not present, return the <paramref name="defaultValue"/>.
    /// </summary>
    /// <param name="methodName"></param>
    /// <param name="defaultValue"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    internal static string GetValue(string methodName, string defaultValue, int index)
    {
        if (csvValues.TryGetValue(methodName, out List<string> methodValues))
        {
            if (methodValues.Count > index)
            {
                return methodValues[index];
            }
        }
        return defaultValue;
    }

    /// <summary>
    ///  One time method to update the method description.
    /// </summary>
    internal static void ReplaceLinesInCsv()
    {
        Dictionary<string, string> replacements = new Dictionary<string, string>()
            {
                { "This instruction", "This method" },
                { "places the results in a vector, and writes the vector to the destination SIMD&FP register.", "places the results in a vector, and returns that vector." },
                { "and writes the result to the destination SIMD&FP register.", "and returns the result." },
                { "and writes the result to the SIMD&FP destination register.", "and returns the result." },
                { "and writes the vector to the destination SIMD&FP register vector.", "and returns the result." },
                { "and  writes the vector to the destination SIMD&FP register.", "and returns the result." },
                { "and writes the result to the general-purpose destination register.", "and returns the result." },
                { "in the destination SIMD&FP register to one", "in the result vector to one" },
                { "in the destination SIMD&FP register to zero", "in the result vector to zero" },
                { "in the  destination SIMD&FP register to zero.", "in the result vector to zero." },
                { " to the destination SIMD&FP register.", " to the result vector." },
                { "and writes the vector to the destination SIMD&FP register.", "and returns the result." },
                { " in this instruction ", " in this method " },
                { "; Lcl frame size = 0", string.Empty },
                { "; Assembly listing for method ", "; " },
            };

        string data_csv = @"data.csv";
        StringBuilder modifiedCsvBuilder = new StringBuilder();
        string[] csvLines = File.ReadAllLines(data_csv);
        foreach (string csvLine in csvLines)
        {
            string blogLine = csvLine;
            foreach (var pair in replacements)
            {
                if (blogLine.Contains(pair.Key, StringComparison.InvariantCulture))
                {
                    blogLine = csvLine.Replace(pair.Key, pair.Value);
                }
            }
            modifiedCsvBuilder.AppendLine(blogLine);
        }
        File.WriteAllText(data_csv, modifiedCsvBuilder.ToString());
    }
}
