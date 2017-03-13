using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionIntBuilder : CILASTNodeBuilder<InstructionInt>
    {
        public override InstructionInt BuildNode(ParseTreeNode node)
        {
            var intArgument = 0;

            var integerNode = node.GetChildIntegerNode();
            intArgument = int.Parse(integerNode.Token.ValueString);

            return new LoadConstantIntShortInstruction
            {
                Argument = intArgument
            };
        }
    }
}
