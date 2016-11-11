using CILantro.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Extensions;

namespace CILantro.Engine.Tests
{
    public class CILantroEngineTests
    {
        private CILantroEngine _engine = new CILantroEngine();

        public static List<object[]> SourceCodes = CILSourceCodesRegister.SourceCodes.Select(sc => new object[] { sc }).ToList();

        [Theory, MemberData(nameof(SourceCodes))]
        public void ShouldCorrectlyInterpretSourceCodes2(string sourceCode)
        {
            var consoleReader = new StreamReader(Console.OpenStandardInput());
            var consoleWriter = new StreamWriter(Console.OpenStandardOutput());

            _engine.Process(sourceCode, consoleReader, consoleWriter);
        }
    }
}
