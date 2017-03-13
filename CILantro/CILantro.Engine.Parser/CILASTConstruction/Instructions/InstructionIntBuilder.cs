using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionIntBuilder : CILASTNodeBuilder<InstructionInt>
    {
        public override InstructionInt BuildNode(ParseTreeNode node)
        {
            var intArgument = 0;

            var integerNode = node.GetChildIntegerNode();
            intArgument = int.Parse(integerNode.Token.ValueString);

            var instructionIntNode = node.GetChildInstructionIntNode();

            var ldci4Token = instructionIntNode.GetChildLdci4TokenNode();
            if(ldci4Token != null)
            {
                return new LoadConstantIntInstruction
                {
                    Argument = intArgument
                };
            }

            var ldci4sToken = instructionIntNode.GetChildLdci4sTokenNode();
            if(ldci4sToken != null)
            {
                return new LoadConstantIntShortInstruction
                {
                    Argument = intArgument
                };
            }

            throw new ArgumentException("Cannot recognize instruction int.");
        }
    }
}
