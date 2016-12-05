using CILantro.Engine.Parser.CILASTBuilder;
using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;

namespace CILantro.Engine.Parser
{
    internal class CILAbstractSyntaxTreeBuilder
    {
        private readonly CILASTProgramRootNodeBuilder _programRootNodeBuilder;

        public CILAbstractSyntaxTreeBuilder()
        {
            _programRootNodeBuilder = new CILASTProgramRootNodeBuilder();
        }

        public CILProgram BuildTree(ParseTree parseTree)
        {
            var programRootNode = _programRootNodeBuilder.BuildNode(parseTree.Root) as CILProgramRoot;

            return new CILProgram
            {
                Root = programRootNode
            };
        }
    }
}
