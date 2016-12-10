using System.Collections.Generic;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILMethod : CILASTNode
    {
        public bool IsEntryPoint { get; set; }

        public List<CILInstruction> Instructions { get; set; }

        public void Invoke(CILProgramRoot program)
        {
            foreach(var instruction in Instructions)
            {
                instruction.Execute(program);
            }
        }
    }
}
