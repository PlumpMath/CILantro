namespace CILantro.Engine.AST.ASTNodes
{
    public abstract class CILInstruction : CILASTNode
    {
        public CILMethod Method { get; set; }

        public abstract int BytesLength { get; }

        public abstract CILInstruction Execute(CILProgram program, CILProgramState state);
    }
}
