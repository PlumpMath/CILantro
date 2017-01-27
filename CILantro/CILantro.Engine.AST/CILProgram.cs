using CILantro.Engine.AST.ASTNodes;

namespace CILantro.Engine.AST
{
    public class CILProgram : CILASTNode
    {
        public CILClass Class { get; set; }
    }
}
