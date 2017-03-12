namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public abstract class InstructionString : CILInstruction
    {
        public string StringArgument { get; set; }
    }
}
