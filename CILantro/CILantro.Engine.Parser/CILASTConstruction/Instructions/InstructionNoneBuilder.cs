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

            var ldci43Token = instructionNoneNode.GetChildLdci43TokenNode();
            if (ldci43Token != null)
                return new LoadConstantInt3Instruction();

            var ldci44Token = instructionNoneNode.GetChildLdci44TokenNode();
            if (ldci44Token != null)
                return new LoadConstantInt4Instruction();

            var ldci45Token = instructionNoneNode.GetChildLdci45TokenNode();
            if (ldci45Token != null)
                return new LoadConstantInt5Instruction();

            var ldci46Token = instructionNoneNode.GetChildLdci46TokenNode();
            if (ldci46Token != null)
                return new LoadConstantInt6Instruction();

            var ldci47Token = instructionNoneNode.GetChildLdci47TokenNode();
            if (ldci47Token != null)
                return new LoadConstantInt7Instruction();

            var ldci48Token = instructionNoneNode.GetChildLdci48TokenNode();
            if (ldci48Token != null)
                return new LoadConstantInt8Instruction();

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
