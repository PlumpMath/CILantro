using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTRetInstructionNodeBuilder : ICILASTNodeBuilder<CILRetInstruction>
    {
        public CILRetInstruction BuildNode(ParseTreeNode parseNode)
        {
            return new CILRetInstruction();
        }
    }
}
