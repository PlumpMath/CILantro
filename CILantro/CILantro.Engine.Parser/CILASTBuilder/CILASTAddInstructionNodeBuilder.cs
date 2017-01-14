using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTAddInstructionNodeBuilder : ICILASTNodeBuilder<CILAddInstruction>
    {
        public CILAddInstruction BuildNode(ParseTreeNode parseNode)
        {
            return new CILAddInstruction();
        }
    }
}
