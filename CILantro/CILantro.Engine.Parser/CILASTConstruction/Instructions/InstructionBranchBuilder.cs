using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionBranchBuilder : CILASTNodeBuilder<InstructionBranch>
    {
        public override InstructionBranch BuildNode(ParseTreeNode node)
        {
            var target = 0;

            var integerNode = node.GetChildIntegerNode();
            target = int.Parse(integerNode.Token.ValueString);

            var instructionBranchNode = node.GetChildInstructionBranchNode();

            var brToken = instructionBranchNode.GetChildBrTokenNode();
            if(brToken != null)
            {
                return new BranchInstruction
                {
                    Target = target
                };
            }

            var brfalseToken = instructionBranchNode.GetChildBrfalseTokenNode();
            if(brfalseToken != null)
            {
                return new BranchIfFalseInstruction
                {
                    Target = target
                };
            }

            var brtrueToken = instructionBranchNode.GetChildBrtrueTokenNode();
            if(brtrueToken != null)
            {
                return new BranchIfTrueInstruction
                {
                    Target = target
                };
            }

            throw new ArgumentException("Cannot recognize instruction branch.");
        }
    }
}
