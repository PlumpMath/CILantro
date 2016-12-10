namespace CILantro.Engine.Parser.CILASTNodes
{
    public abstract class CILInstruction : CILASTNode
    {
        public abstract void Execute(CILProgramRoot program);
    }
}
