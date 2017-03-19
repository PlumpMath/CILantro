namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantIntShortInstruction : InstructionInt
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(Argument);
            return Method.GetNextInstruction(this);
        }
    }
}
