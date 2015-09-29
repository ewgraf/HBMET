using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn_cs_compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nnFileNames = Directory.GetFiles(Environment.CurrentDirectory, "_*.cs");
            foreach (var filePath in nnFileNames)
            {
                Process.Start(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe", filePath);
            }
        }
    }
}
