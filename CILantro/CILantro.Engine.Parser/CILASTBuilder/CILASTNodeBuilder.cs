using CILantro.Engine.Parser.CILAST;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public abstract class CILASTNodeBuilder
    {
        public abstract CILASTNode BuildNode(ParseTreeNode parseNode);
    }
}
