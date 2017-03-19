namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfFalseInstruction : InstructionBranch
    {
        public override int BytesLength => 5;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value = (int)state.Stack.Pop();

            if (value == 0) return Method.GetInstructionByBranchTarget(this, Target);
            return Method.GetNextInstruction(this);
        }
    }
}
