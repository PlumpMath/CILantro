namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantInt7Instruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(7);
            return Method.GetNextInstruction(this);
        }
    }
}
