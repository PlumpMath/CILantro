using CILantro.Engine.AST.ASTNodes.Instructions;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionStringBuilder : CILASTNodeBuilder<InstructionString>
    {
        public override InstructionString BuildNode(ParseTreeNode node)
        {
            return new LoadStringInstruction();
        }
    }
}
