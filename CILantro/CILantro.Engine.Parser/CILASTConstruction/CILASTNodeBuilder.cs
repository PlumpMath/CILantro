using CILantro.Engine.AST;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction
{
    public abstract class CILASTNodeBuilder<T>
        where T : CILASTNode
    {
        public abstract T BuildNode(ParseTreeNode node);
    }
}
