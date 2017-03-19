using System;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfTrueInstruction : InstructionBranch
    {
        public override int BytesLength => 5;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            throw new NotImplementedException();
        }
    }
}
