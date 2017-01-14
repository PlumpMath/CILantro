using System;
using CILantro.Shared;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILAddInstruction : CILInstruction
    {
        public override CILInstruction Execute(CILProgramRoot program, CILProgramState state)
        {
            var value1 = (int)state.Stack.Pop();
            var value2 = (int)state.Stack.Pop();
            var result = value1 + value2;

            state.Stack.Push(result);

            return Method.GetNextInstruction(Order);
        }
    }
}
