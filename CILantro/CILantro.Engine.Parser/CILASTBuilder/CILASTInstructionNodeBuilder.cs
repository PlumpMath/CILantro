using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTInstructionNodeBuilder : ICILASTNodeBuilder<CILInstruction>
    {
        private readonly CILASTCallInstructionNodeBuilder _callInstructionNodeBuilder;
        private readonly CILASTPopInstructionNodeBuilder _popInstructionNodeBuilder;
        private readonly CILASTRetInstructionNodeBuilder _retInstructionNodeBuilder;

        public CILASTInstructionNodeBuilder()
        {
            _callInstructionNodeBuilder = new CILASTCallInstructionNodeBuilder();
            _popInstructionNodeBuilder = new CILASTPopInstructionNodeBuilder();
            _retInstructionNodeBuilder = new CILASTRetInstructionNodeBuilder();
        }

        public CILInstruction BuildNode(ParseTreeNode parseNode)
        {
            var callInstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsCallInstructionNode());
            if (callInstructionParseNode != null)
                return _callInstructionNodeBuilder.BuildNode(callInstructionParseNode);

            var popInstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsPopInstructionNode());
            if (popInstructionParseNode != null)
                return _popInstructionNodeBuilder.BuildNode(popInstructionParseNode);

            var retInstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsRetInstructionNode());
            if (retInstructionParseNode != null)
                return _retInstructionNodeBuilder.BuildNode(retInstructionParseNode);

            return null;
        }
    }
}
