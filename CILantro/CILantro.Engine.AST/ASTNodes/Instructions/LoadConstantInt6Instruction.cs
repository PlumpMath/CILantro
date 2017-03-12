namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantInt6Instruction : InstructionNone
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(6);
            return Method.GetNextInstruction(this);
        }
    }
}
