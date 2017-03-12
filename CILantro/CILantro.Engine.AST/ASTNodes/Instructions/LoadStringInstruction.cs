namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadStringInstruction : InstructionString
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(StringArgument);
            return Method.GetNextInstruction(this);
        }
    }
}
