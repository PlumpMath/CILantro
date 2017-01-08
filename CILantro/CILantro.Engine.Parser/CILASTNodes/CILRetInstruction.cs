using CILantro.Shared;
using System;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILRetInstruction : CILInstruction
    {
        public override CILInstruction Execute(CILProgramRoot program, CILProgramState state)
        {
            return Method.GetNextInstruction(Order);
        }
    }
}
