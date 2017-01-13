using System;
using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTLoadInt32InstructionNodeBuilder : ICILASTNodeBuilder<CILLoadInt32Instruction>
    {
        public CILLoadInt32Instruction BuildNode(ParseTreeNode parseNode)
        {
            int? value = null;

            if (parseNode.IsLoadInt320InstructionNode()) value = 0;
            if (parseNode.IsLoadInt321InstructionNode()) value = 1;
            if (parseNode.IsLoadInt322InstructionNode()) value = 2;
            if (parseNode.IsLoadInt323InstructionNode()) value = 3;
            if (parseNode.IsLoadInt324InstructionNode()) value = 4;

            return new CILLoadInt32Instruction
            {
                Value = value.Value
            };
        }
    }
}
