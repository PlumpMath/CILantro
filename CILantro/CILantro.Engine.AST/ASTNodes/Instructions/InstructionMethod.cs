namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public abstract class InstructionMethod : CILInstruction
    {
        public string AssemblyName { get; set; }

        public string ClassName { get; set; }

        public string MethodName { get; set; }
    }
}
