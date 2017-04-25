namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class ComplementInstruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var argument = (int)state.Stack.Pop();

            var result = ~argument;
            state.Stack.Push(result);

            return Method.GetNextInstruction(this);
        }
    }
}
