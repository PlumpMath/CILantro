using CILantro.Engine.AST;
using CILantro.Engine.Parser.CILASTConstruction;
using Irony;
using System;
using System.Linq;

namespace CILantro.Engine.Parser
{
    public class CILParser
    {
        private readonly Irony.Parsing.Parser _parser;
        private readonly ProgramBuilder _astBuilder;

        public CILParser()
        {
            _parser = new Irony.Parsing.Parser(new CILGrammar());
            _astBuilder = new ProgramBuilder();
        }

        public CILProgram Parse(string sourceCode)
        {
            var parseTree = _parser.Parse(sourceCode);
            if (parseTree.Status == Irony.Parsing.ParseTreeStatus.Parsed)
            {
                var result = _astBuilder.BuildNode(parseTree.Root);
                return result;
            }

            var error = parseTree.ParserMessages.First();
            var errorMessage = BuildErrorMessage(error);
            throw new ArgumentException(errorMessage);
        }

        private string BuildErrorMessage(LogMessage logMessage)
        {
            return $"Cannot parse the source code:\n{logMessage.Location}: {logMessage.Message}.";
        }
    }
}
