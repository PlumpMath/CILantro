using System;
using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTLoadStringInstructionNodeBuilder : ICILASTNodeBuilder<CILLoadStringInstruction>
    {
        public CILLoadStringInstruction BuildNode(ParseTreeNode parseNode)
        {
            return new CILLoadStringInstruction();
        }
    }
}
