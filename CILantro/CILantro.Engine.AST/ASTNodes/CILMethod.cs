using System;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Engine.AST.ASTNodes
{
    public class CILMethod : CILASTNode
    {
        public List<CILInstruction> Instructions { get; set; }

        public CILInstruction GetNextInstruction(CILInstruction currentInstruction)
        {
            var currentIndex = Instructions.IndexOf(currentInstruction);
            var nextIndex = currentIndex + 1;

            if (nextIndex >= Instructions.Count)
                return null;

            return Instructions[currentIndex + 1];
        }

        public CILInstruction GetInstructionByBranchTarget(CILInstruction currentInstruction, int branchTarget)
        {
            var bytesPosition = GetBytesPosition(GetNextInstruction(currentInstruction));
            var newBytesPosition = bytesPosition + branchTarget;
            return GetInstructionByBytesPosition(newBytesPosition);
        }

        private int GetBytesPosition(CILInstruction instruction)
        {
            var index = Instructions.IndexOf(instruction);
            var previousInstructions = Instructions.Take(index);
            return previousInstructions.Sum(i => i.BytesLength);
        }

        private CILInstruction GetInstructionByBytesPosition(int bytesPosition)
        {
            var currentPosition = 0;
            foreach(var instruction in Instructions)
            {
                if (currentPosition == bytesPosition) return instruction;
                currentPosition += instruction.BytesLength;
            }

            throw new ArgumentException("Cannot find instruction with specified bytesPosition.");
        }
    }
}
