using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionStringBuilder : CILASTNodeBuilder<InstructionString>
    {
        public override InstructionString BuildNode(ParseTreeNode node)
        {
            var stringArgument = string.Empty;

            var complexQuotedStringNode = node.GetChildComplexQuotedStringNode();
            var quotedStringNode = complexQuotedStringNode.GetChildQuotedStringNode();
            stringArgument = quotedStringNode.Token.ValueString;

            return new LoadStringInstruction
            {
                StringArgument = stringArgument
            };
        }
    }
}
