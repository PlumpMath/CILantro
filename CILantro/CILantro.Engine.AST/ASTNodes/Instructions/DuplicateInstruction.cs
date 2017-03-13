namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class DuplicateInstruction : InstructionNone
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var argument = state.Stack.Pop();

            state.Stack.Push(argument);
            state.Stack.Push(argument);

            return Method.GetNextInstruction(this);
        }
    }
}
