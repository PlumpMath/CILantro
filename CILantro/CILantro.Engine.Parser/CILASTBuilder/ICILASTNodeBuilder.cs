using CILantro.Engine.Parser.CILAST;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public interface ICILASTNodeBuilder<TASTNode>
        where TASTNode : CILASTNode
    {
        TASTNode BuildNode(ParseTreeNode parseNode);
    }
}
