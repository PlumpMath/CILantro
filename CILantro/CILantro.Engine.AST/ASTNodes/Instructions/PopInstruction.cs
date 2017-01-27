namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class PopInstruction : InstructionNone
    {
        public override CILInstruction Execute(CILProgram program)
        {
            return Method.GetNextInstruction(this);
        }
    }
}
