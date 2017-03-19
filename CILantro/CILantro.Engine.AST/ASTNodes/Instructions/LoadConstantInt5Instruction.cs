namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantInt5Instruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(5);
            return Method.GetNextInstruction(this);
        }
    }
}
