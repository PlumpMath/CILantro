using System;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LeaveInstruction : InstructionBranch
    {
        public override int BytesLength
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            throw new NotImplementedException();
        }
    }
}
