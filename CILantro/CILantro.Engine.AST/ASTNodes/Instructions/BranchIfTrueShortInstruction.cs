namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfTrueShortInstruction : InstructionBranch
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value = (int)state.Stack.Pop();

            if (value == 0) return Method.GetNextInstruction(this);
            return Method.GetInstructionByBranchTarget(this, Target);
        }
    }
}
