﻿using CILantro.Engine.AST.ASTNodes.Instructions;
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

            var beqToken = instructionBranchNode.GetChildBeqTokenNode();
            if(beqToken != null)
            {
                return new BranchIfEqualInstruction
                {
                    Target = target
                };
            }

            var beqsToken = instructionBranchNode.GetChildBeqsTokenNode();
            if(beqsToken != null)
            {
                return new BranchIfEqualShortInstruction
                {
                    Target = target
                };
            }

            var bgeToken = instructionBranchNode.GetChildBgeTokenNode();
            if(bgeToken != null)
            {
                return new BranchIfGreaterOrEqualInstruction
                {
                    Target = target
                };
            }

            var bgesToken = instructionBranchNode.GetChildBgesTokenNode();
            if(bgesToken != null)
            {
                return new BranchIfGreaterOrEqualShortInstruction
                {
                    Target = target
                };
            }

            var bgeunToken = instructionBranchNode.GetChildBgeunTokenNode();
            if(bgeunToken != null)
            {
                return new BranchIfGreaterOrEqualUnsignedInstruction
                {
                    Target = target
                };
            }

            var bgeunsToken = instructionBranchNode.GetChildBgeunsTokenNode();
            if(bgeunsToken != null)
            {
                return new BranchIfGreaterOrEqualUnsignedShortInstruction
                {
                    Target = target
                };
            }

            var bgtToken = instructionBranchNode.GetChildBgtTokenNode();
            if(bgtToken != null)
            {
                return new BranchIfGreaterInstruction
                {
                    Target = target
                };
            }

            var bgtsToken = instructionBranchNode.GetChildBgtsTokenNode();
            if(bgtsToken != null)
            {
                return new BranchIfGreaterShortInstruction
                {
                    Target = target
                };
            }

            var bgtunToken = instructionBranchNode.GetChildBgtunTokenNode();
            if(bgtunToken != null)
            {
                return new BranchIfGreaterUnsignedInstruction
                {
                    Target = target
                };
            }

            var bgtunsToken = instructionBranchNode.GetChildBgtunsTokenNode();
            if(bgtunsToken != null)
            {
                return new BranchIfGreaterUnsignedShortInstruction
                {
                    Target = target
                };
            }

            var bleToken = instructionBranchNode.GetChildBleTokenNode();
            if(bleToken != null)
            {
                return new BranchIfLessOrEqualInstruction
                {
                    Target = target
                };
            }

            var blesToken = instructionBranchNode.GetChildBlesTokenNode();
            if(blesToken != null)
            {
                return new BranchIfLessOrEqualShortInstruction
                {
                    Target = target
                };
            }

            var bleunToken = instructionBranchNode.GetChildBleunTokenNode();
            if(bleunToken != null)
            {
                return new BranchIfLessOrEqualUnsignedInstruction
                {
                    Target = target
                };
            }

            var bleunsToken = instructionBranchNode.GetChildBleunsTokenNode();
            if(bleunsToken != null)
            {
                return new BranchIfLessOrEqualUnsignedShortInstruction
                {
                    Target = target
                };
            }

            var bltToken = instructionBranchNode.GetChildBltTokenNode();
            if(bltToken != null)
            {
                return new BranchIfLessInstruction
                {
                    Target = target
                };
            }

            var bltsToken = instructionBranchNode.GetChildBltsTokenNode();
            if(bltsToken != null)
            {
                return new BranchIfLessShortInstruction
                {
                    Target = target
                };
            }

            var bltunToken = instructionBranchNode.GetChildBltunTokenNode();
            if(bltunToken != null)
            {
                return new BranchIfLessUnsignedInstruction
                {
                    Target = target
                };
            }

            var bltunsToken = instructionBranchNode.GetChildBltunsTokenNode();
            if(bltunsToken != null)
            {
                return new BranchIfLessUnsignedShortInstruction
                {
                    Target = target
                };
            }

            var bneunToken = instructionBranchNode.GetChildBneunTokenNode();
            if(bneunToken != null)
            {
                return new BranchIfNotEqualUnsignedInstruction
                {
                    Target = target
                };
            }

            var bneunsToken = instructionBranchNode.GetChildBneunsTokenNode();
            if(bneunsToken != null)
            {
                return new BranchIfNotEqualUnsignedShortInstruction
                {
                    Target = target
                };
            }

            var brToken = instructionBranchNode.GetChildBrTokenNode();
            if(brToken != null)
            {
                return new BranchInstruction
                {
                    Target = target
                };
            }

            var brsToken = instructionBranchNode.GetChildBrsTokenNode();
            if(brsToken != null)
            {
                return new BranchShortInstruction
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

            var brfalsesToken = instructionBranchNode.GetChildBrfalsesTokenNode();
            if(brfalsesToken != null)
            {
                return new BranchIfFalseShortInstruction
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

            var brtruesToken = instructionBranchNode.GetChildBrtruesTokenNode();
            if (brtruesToken != null)
            {
                return new BranchIfTrueShortInstruction
                {
                    Target = target
                };
            }

            var leaveToken = instructionBranchNode.GetChildLeaveTokenNode();
            if(leaveToken != null)
            {
                return new LeaveInstruction
                {
                    Target = target
                };
            }

            var leavesToken = instructionBranchNode.GetChildLeavesTokenNode();
            if(leavesToken != null)
            {
                return new LeaveShortInstruction
                {
                    Target = target
                };
            }

            throw new ArgumentException("Cannot recognize instruction branch.");
        }
    }
}
