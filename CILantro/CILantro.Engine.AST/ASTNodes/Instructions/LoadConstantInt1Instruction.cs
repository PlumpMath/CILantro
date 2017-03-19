namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantInt1Instruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(1);
            return Method.GetNextInstruction(this);
        }
    }
}
