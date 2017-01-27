namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class RetInstruction : InstructionNone
    {
        public override CILInstruction Execute(CILProgram program)
        {
            return Method.GetNextInstruction(this);
        }
    }
}
