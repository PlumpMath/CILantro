using CILantro.Engine.AST;
using CILantro.Engine.AST.ASTNodes;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction
{
    public class ProgramBuilder : CILASTNodeBuilder<CILProgram>
    {
        private ClassBuilder _classBuilder;

        public ProgramBuilder()
        {
            _classBuilder = new ClassBuilder();
        }

        public override CILProgram BuildNode(ParseTreeNode node)
        {
            CILClass cilClass = null;

            var declarationNode = node.GetChildDeclarationNode();
            cilClass = _classBuilder.BuildNode(declarationNode);

            return new CILProgram
            {
                Class = cilClass
            };
        }
    }
}
