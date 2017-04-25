using System;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class AddOverflowUnsignedInstruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            throw new NotImplementedException();
        }
    }
}
