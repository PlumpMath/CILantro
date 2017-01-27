using System.Collections.Generic;

namespace CILantro.Engine.AST.ASTNodes
{
    public class CILMethod : CILASTNode
    {
        public List<CILInstruction> Instructions { get; set; }
    }
}
