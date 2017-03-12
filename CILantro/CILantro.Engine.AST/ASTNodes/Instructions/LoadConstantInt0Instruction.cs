using System;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class LoadConstantInt0Instruction : InstructionNone
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            state.Stack.Push(0);
            return Method.GetNextInstruction(this);
        }
    }
}
