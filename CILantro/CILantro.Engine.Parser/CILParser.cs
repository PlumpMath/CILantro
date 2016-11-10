using System;

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

            throw new ArgumentException("Cannot parse the source code.");
        }
    }
}
