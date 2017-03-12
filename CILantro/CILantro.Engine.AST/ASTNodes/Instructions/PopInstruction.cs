namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class PopInstruction : InstructionNone
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            return Method.GetNextInstruction(this);
        }
    }
}
