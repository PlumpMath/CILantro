namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class NoOperationInstruction : InstructionNone
    {
        public override int BytesLength => 1;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            return Method.GetNextInstruction(this);
        }
    }
}
