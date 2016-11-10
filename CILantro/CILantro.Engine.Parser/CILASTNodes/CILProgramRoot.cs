namespace CILantro.Engine.Parser.CILAST
{
    public class CILProgramRoot : CILASTNode
    {
        public CILAssembly Assembly { get; set; }

        public CILClass Class { get; set; }
    }
}
