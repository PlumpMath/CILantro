using CILantro.Engine.Parser.CILAST;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTAssemblyNodeBuilder : CILASTNodeBuilder
    {
        public override CILASTNode BuildNode(ParseTreeNode parseNode)
        {
            var resultNode = new CILAssembly();

            return resultNode;
        }
    }
}
