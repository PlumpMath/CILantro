namespace CILantro.Engine.Parser.CILASTNodes
{
    public abstract class CILInstruction : CILASTNode
    {
        public CILMethod Method { get; set; }

        public int Order { get; set; }

        public abstract CILInstruction Execute(CILProgramRoot program);
    }
}
