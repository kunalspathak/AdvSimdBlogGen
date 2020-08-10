using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Intrinsics;
using System.Diagnostics;
using System.IO;
using System.Reflection;

public partial class AdvSimdMethods
{
    private static string apiResult;


    private static Vector64<short> Vector64short_0 = Vector64.Create((short)11, 12, 13, 14);
    private static Vector64<double> Vector64double_0 = Vector64.Create((double)11.5);
    private static Vector64<float> Vector64float_0 = Vector64.Create((float)11.5f, 12.5f);
    private static Vector64<float> Vector64float_1 = Vector64.Create((float)21.5f, 22.5f);
    private static Vector64<byte> Vector64byte_0 = Vector64.Create((byte)11, 12, 13, 14, 15, 16, 17, 18);
    private static Vector64<byte> Vector64byte_1 = Vector64.Create((byte)21, 22, 23, 24, 25, 26, 27, 28);
    private static Vector64<byte> Vector64byte_2 = Vector64.Create((byte)31, 32, 33, 34, 35, 36, 37, 38);
    private static Vector128<ushort> Vector128ushort_0 = Vector128.Create((ushort)11, 12, 13, 14, 15, 16, 17, 18);
    private static Vector128<byte> Vector128byte_0 = Vector128.Create((byte)11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26);
    private static Vector128<byte> Vector128byte_1 = Vector128.Create((byte)21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36);
    private static Vector128<ushort> Vector128ushort_1 = Vector128.Create((ushort)11, 12, 13, 14, 15, 16, 17, 18);
    private static Vector64<ushort> Vector64ushort_0 = Vector64.Create((ushort)11, 12, 13, 14);
    private static Vector64<long> Vector64long_0 = Vector64.Create((long)11);
    private static Vector64<int> Vector64int_0 = Vector64.Create((int)11, 12);
    private static Vector64<long> Vector64long_1 = Vector64.Create((long)11);
    private static Vector64<double> Vector64double_1 = Vector64.Create((double)11.5);
    private static byte byte_0 = 0;
    private static Vector128<short> Vector128short_0 = Vector128.Create((short)11, 12, 13, 14, 15, 16, 17, 18);
    private static Vector64<float> Vector64float_2 = Vector64.Create((float)11.5f, 12.5f);
    private static Vector64<double> Vector64double_2 = Vector64.Create((double)11);
    private static byte byte_1 = 1;
    private static Vector128<double> Vector128double_0 = Vector128.Create((double)11.5, 12.5);
    private static Vector64<short> Vector64short_1 = Vector64.Create((short)21, 22, 23, 24);
    private static Vector64<short> Vector64short_2 = Vector64.Create((short)31, 32, 33, 34);
    private static Vector128<int> Vector128int_0 = Vector128.Create((int)11, 12, 13, 14);
    private static Vector128<short> Vector128short_1 = Vector128.Create((short)21, 22, 23, 24, 25, 26, 27, 28);
    private static Vector64<sbyte> Vector64sbyte_0 = Vector64.Create((sbyte)11, 12, 13, 14, 15, 16, 17, 18);
    private static Vector128<float> Vector128float_0 = Vector128.Create((float)11.5f, 12.5f, 13.5f, 14.5f);
    private static Vector64<int> Vector64int_1 = Vector64.Create((int)21, 22);

    private static int[] intArray = new int[] { 11, 12 };
    private static byte[] byteArray = new byte[] { 11, 12, 13, 14, 15, 16, 17, 18 };

    private static StringBuilder csvGenerator = new StringBuilder();
    private static Dictionary<string, List<string>> csvValues = null;


    public static unsafe void Main(string[] args)
    {
        ReadCsv();
        Run();
        if (csvGenerator.Length > 0)
        {
            string dirName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            File.WriteAllText(Path.Combine(dirName, "data.csv"), csvGenerator.ToString());
        }
    }

    private static void ReadCsv()
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
                    var methodEntry = csvEntry.Split("|").ToList();
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
    private static string GetValue(string methodName, string defaultValue, int index)
    {
        if (csvValues.TryGetValue("", out List<string> methodValues))
        {
            if (methodValues.Count > index)
            {
                return methodValues[index];
            }
        }
        return defaultValue;
    }
}
