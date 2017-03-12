namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantInt3Instruction : InstructionNone
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(3);
            return Method.GetNextInstruction(this);
        }
    }
}
