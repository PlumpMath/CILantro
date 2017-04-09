namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchIfNotEqualUnsignedInstruction : InstructionBranch
    {
        public override int BytesLength => 5;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var value1 = state.Stack.Pop();
            var value2 = state.Stack.Pop();

            if (!value1.Equals(value2)) return Method.GetInstructionByBranchTarget(this, Target);
            return Method.GetNextInstruction(this);
        }
    }
}
