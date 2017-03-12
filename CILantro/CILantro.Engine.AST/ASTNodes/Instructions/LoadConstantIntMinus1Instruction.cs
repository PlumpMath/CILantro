namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantIntMinus1Instruction : InstructionNone
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(-1);
            return Method.GetNextInstruction(this);
        }
    }
}
