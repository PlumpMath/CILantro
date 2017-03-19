namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class BranchInstruction : InstructionBranch
    {
        public override int BytesLength => 5;

        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var bytesPosition = Method.GetBytesPosition(Method.GetNextInstruction(this));
            var newBytesPosition = bytesPosition + Target;
            return Method.GetInstructionByBytesPosition(newBytesPosition);
        }
    }
}
