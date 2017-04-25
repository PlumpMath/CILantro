namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class AndInstruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var argument1 = (int)state.Stack.Pop();
            var argument2 = (int)state.Stack.Pop();

            var result = argument1 == 1 && argument2 == 1 ? 1 : 0;
            state.Stack.Push(result);

            return Method.GetNextInstruction(this);
        }
    }
}
