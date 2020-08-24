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
}
