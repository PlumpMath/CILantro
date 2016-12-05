namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILAssembly : CILASTNode
    {
        public string Name { get; set; }

        public bool IsExternal { get; set; }
    }
}
