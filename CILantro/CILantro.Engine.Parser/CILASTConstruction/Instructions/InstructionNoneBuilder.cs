using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionNoneBuilder : CILASTNodeBuilder<InstructionNone>
    {
        public override InstructionNone BuildNode(ParseTreeNode node)
        {
            var instructionNoneNode = node.GetChildInstructionNoneNode();

            var ldci40Token = instructionNoneNode.GetChildLdci40TokenNode();
            if (ldci40Token != null)
                return new LoadConstantInt0Instruction();

            var ldci41Token = instructionNoneNode.GetChildLdci41TokenNode();
            if (ldci41Token != null)
                return new LoadConstantInt1Instruction();

            var ldci42Token = instructionNoneNode.GetChildLdci42TokenNode();
            if (ldci42Token != null)
                return new LoadConstantInt2Instruction();

            var retTokenNode = instructionNoneNode.GetChildRetTokenNode();
            if (retTokenNode != null)
                return new RetInstruction();

            var popTokenNode = instructionNoneNode.GetChildPopTokenNode();
            if (popTokenNode != null)
                return new PopInstruction();

            throw new ArgumentException("Cannot recognize instruction none.");
        }
    }
}
