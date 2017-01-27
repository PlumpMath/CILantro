using CILantro.Engine.AST.ASTNodes;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction
{
    public class ClassBuilder : CILASTNodeBuilder<CILClass>
    {
        private MethodBuilder _methodBuilder;

        public ClassBuilder()
        {
            _methodBuilder = new MethodBuilder();
        }

        public override CILClass BuildNode(ParseTreeNode node)
        {
            CILMethod cilMethod = null;

            var classDeclarationsNode = node.GetChildClassDeclarationsNode();
            var classDeclarationNode = classDeclarationsNode.GetChildClassDeclarationNode();
            cilMethod = _methodBuilder.BuildNode(classDeclarationNode);

            return new CILClass
            {
                Method = cilMethod
            };
        }
    }
}
