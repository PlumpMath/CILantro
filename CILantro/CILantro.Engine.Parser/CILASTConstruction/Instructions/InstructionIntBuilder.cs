using CILantro.Engine.AST.ASTNodes.Instructions;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionIntBuilder : CILASTNodeBuilder<InstructionInt>
    {
        public override InstructionInt BuildNode(ParseTreeNode node)
        {
            return new LoadConstantIntShortInstruction();
        }
    }
}
