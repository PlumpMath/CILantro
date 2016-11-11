using Irony;
using System;
using System.Linq;

namespace CILantro.Engine.Parser
{
    public class CILParser
    {
        private readonly Irony.Parsing.Parser _parser = new Irony.Parsing.Parser(new CILGrammar());

        private readonly CILAbstractSyntaxTreeBuilder _astBuilder = new CILAbstractSyntaxTreeBuilder();

        public CILProgram Parse(string sourceCode)
        {
            var parseTree = _parser.Parse(sourceCode);
            if(parseTree.Status == Irony.Parsing.ParseTreeStatus.Parsed)
            {
                var result = _astBuilder.BuildTree(parseTree);
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
