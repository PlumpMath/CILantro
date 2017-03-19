namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantIntInstruction : InstructionInt
    {
        public override int BytesLength => 5;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(Argument);
            return Method.GetNextInstruction(this);
        }
    }
}
