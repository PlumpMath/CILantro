namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadStringInstruction : InstructionString
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(Argument);
            return Method.GetNextInstruction(this);
        }
    }
}
