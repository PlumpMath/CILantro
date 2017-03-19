namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchShortInstruction : InstructionBranch
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            return Method.GetInstructionByBranchTarget(this, Target);
        }
    }
}
