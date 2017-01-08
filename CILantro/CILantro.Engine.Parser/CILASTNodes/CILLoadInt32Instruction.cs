using System;
using CILantro.Shared;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILLoadInt32Instruction : CILInstruction
    {
        public int Value { get; set; }

        public override CILInstruction Execute(CILProgramRoot program, CILProgramState state)
        {
            state.Stack.Push(Value);

            return Method.GetNextInstruction(Order);
        }
    }
}
