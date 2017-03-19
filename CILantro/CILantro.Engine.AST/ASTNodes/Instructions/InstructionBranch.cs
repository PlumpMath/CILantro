namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public abstract class InstructionBranch : CILInstruction
    {
        public int Target { get; set; }
    }
}
