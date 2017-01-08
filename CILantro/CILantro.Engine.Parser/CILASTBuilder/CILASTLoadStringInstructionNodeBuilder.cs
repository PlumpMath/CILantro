using System;
using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTLoadStringInstructionNodeBuilder : ICILASTNodeBuilder<CILLoadStringInstruction>
    {
        public CILLoadStringInstruction BuildNode(ParseTreeNode parseNode)
        {
            var stringValueParseNode = parseNode.ChildNodes.First(cn => cn.IsStringValueNode());
            var stringValue = stringValueParseNode.Token.ValueString;

            return new CILLoadStringInstruction
            {
                Value = stringValue
            };
        }
    }
}
