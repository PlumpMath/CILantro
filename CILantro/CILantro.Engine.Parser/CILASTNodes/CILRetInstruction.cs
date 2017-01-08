using System;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILRetInstruction : CILInstruction
    {
        public override CILInstruction Execute(CILProgramRoot program)
        {
            return Method.GetNextInstruction(Order);
        }
    }
}
