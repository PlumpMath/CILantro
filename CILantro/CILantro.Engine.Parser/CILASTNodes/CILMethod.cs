using System.Collections.Generic;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILMethod : CILASTNode
    {
        public bool IsEntryPoint { get; set; }

        public List<CILInstruction> Instructions { get; set; }
    }
}
