using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public interface ICILASTNodeBuilder<TASTNode>
        where TASTNode : CILASTNode
    {
        TASTNode BuildNode(ParseTreeNode parseNode);
    }
}
