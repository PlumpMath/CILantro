namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class CheckIfGreaterUnsignedInstruction : InstructionNone
    {
        public override int BytesLength => 2;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var argument2 = (int)state.Stack.Pop();
            var argument1 = (int)state.Stack.Pop();

            var result = argument1 > argument2 ? 1 : 0;
            state.Stack.Push(result);

            return Method.GetNextInstruction(this);
        }
    }
}
