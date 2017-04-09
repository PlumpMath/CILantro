namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LeaveShortInstruction : InstructionBranch
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            return Method.GetInstructionByBranchTarget(this, Target);
        }
    }
}
