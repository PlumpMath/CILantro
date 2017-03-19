namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfFalseShortInstruction : InstructionBranch
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value = (int)state.Stack.Pop();

            if (value == 0) return Method.GetInstructionByBranchTarget(this, Target);
            return Method.GetNextInstruction(this);
        }
    }
}
