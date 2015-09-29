using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn_cs_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] nnFileNames = Directory.GetFiles(Environment.CurrentDirectory, "SANN_CS_Code_*.cs");
            string[] nnFileNames = Directory.GetFiles(Environment.CurrentDirectory, "*.cs");
            foreach (var filePath in nnFileNames)
            {
                //SANN_CS_Code__а-1.cs
                var text = File.ReadAllText(filePath);
                //var symbol = Between("SANN_CS_Code_", ".cs", Path.GetFileName(filePath));
                text = text.Replace("Console.WriteLine(\" Predicted Category = \" + __statist_PredCat);", "");
                text = text.Replace("Console.WriteLine(\" Confidence Level = {0}\", __statist_ConfLevel);", "return new string[] { __statist_PredCat, __statist_ConfLevel.ToString() };");
                //text = text.Replace("Predict", "Predict" + symbol.Replace("-", "").Replace("%", "_").Replace(",", "_").Replace(".", "_").Replace("(", "_").Replace(")", "_").Replace(" ", "_"));
                text = text.Replace("Predict", "Predict"+Path.GetFileNameWithoutExtension(filePath));

                string functionName = Between("public static void ", "( double[] ContInputs )", text);
                //string functionName = Between("public static void ", "( string[] CatInputs )", text);

                text = text.Replace(functionName + "( ContInputs )", "return " + functionName + "( ContInputs )");
                text = text.Replace(functionName, "foo");
                text = text.Replace("{\n", "{\n#region").Replace("}\n", "}\n#endregion");
                text = text.Replace("public static void", "public static string[]");
                text = text.Replace("NaN", "0");
                File.WriteAllText(filePath.Replace(".cs", "-new.cs"), text);
            }
        }
        private static string Between(string a, string b, string _s)
        {
            int from = _s.IndexOf(a) + a.Length;
            int to = _s.LastIndexOf(b);
            return _s.Substring(from, to - from);
        }
    }
}
