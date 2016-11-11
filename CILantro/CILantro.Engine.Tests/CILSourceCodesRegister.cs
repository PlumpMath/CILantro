using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CILantro.Engine.Tests
{
    internal static class CILSourceCodesRegister
    {
        private static string SourceCodesDirectoryName = "CILSourceCodes";

        private static List<string> FileNames = new List<string>
        {
            "001_empty.il",
            //"002_read_key.il"
        };

        public static List<string> SourceCodes = FileNames.Select(fn => GetSourceCode(fn)).ToList();

        private static string GetSourceCode(string fileName)
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uriBuilder = new UriBuilder(codeBase);
            var assemblyPath = Uri.UnescapeDataString(uriBuilder.Path);
            var assemblyDirPath = Path.GetDirectoryName(assemblyPath);
            var filePath = Path.Combine(assemblyDirPath, SourceCodesDirectoryName, fileName);
            var sourceCode = File.ReadAllText(filePath);

            return sourceCode;
        }
    }
}
