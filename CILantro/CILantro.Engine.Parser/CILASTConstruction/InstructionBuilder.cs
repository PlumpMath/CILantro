using CILantro.Engine.AST.ASTNodes;
using CILantro.Engine.Parser.CILASTConstruction.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction
{
    public class InstructionBuilder : CILASTNodeBuilder<CILInstruction>
    {
        private InstructionNoneBuilder _instructionNoneBuilder;
        private InstructionMethodBuilder _instructionMethodBuilder;

        public InstructionBuilder()
        {
            _instructionNoneBuilder = new InstructionNoneBuilder();
            _instructionMethodBuilder = new InstructionMethodBuilder();
        }

        public override CILInstruction BuildNode(ParseTreeNode node)
        {
            var instructionNoneNode = node.GetChildInstructionNoneNode();
            if (instructionNoneNode != null)
                return _instructionNoneBuilder.BuildNode(node);

            var instructionMethodNode = node.GetChildInstructionMethodNode();
            if (instructionMethodNode != null)
                return _instructionMethodBuilder.BuildNode(node);

            return null;
        }
    }
}
