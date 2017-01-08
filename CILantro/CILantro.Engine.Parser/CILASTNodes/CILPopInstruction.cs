using System;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILPopInstruction : CILInstruction
    {
        public override CILInstruction Execute(CILProgramRoot program)
        {
            return Method.GetNextInstruction(Order);
        }
    }
}
