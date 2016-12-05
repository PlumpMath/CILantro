namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILCallInstruction : CILInstruction
    {
        public string MethodAssemblyName { get; set; }

        public string MethodClassName { get; set; }

        public string MethodName { get; set; }
    }
}
