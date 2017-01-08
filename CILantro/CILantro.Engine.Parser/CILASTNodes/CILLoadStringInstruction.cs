using CILantro.Shared;
using System;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILLoadStringInstruction : CILInstruction
    {
        public string StringValue { get; set; }

        public override CILInstruction Execute(CILProgramRoot program, CILProgramState state)
        {
            state.Stack.Push(StringValue);

            return Method.GetNextInstruction(Order);
        }
    }
}
