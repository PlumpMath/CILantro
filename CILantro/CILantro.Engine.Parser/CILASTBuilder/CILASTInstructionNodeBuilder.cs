using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;
using System;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTInstructionNodeBuilder : ICILASTNodeBuilder<CILInstruction>
    {
        private readonly CILASTCallInstructionNodeBuilder _callInstructionNodeBuilder;
        private readonly CILASTLoadStringInstructionNodeBuilder _loadStringInstructionNodeBuilder;
        private readonly CILASTPopInstructionNodeBuilder _popInstructionNodeBuilder;
        private readonly CILASTRetInstructionNodeBuilder _retInstructionNodeBuilder;

        public CILASTInstructionNodeBuilder()
        {
            _callInstructionNodeBuilder = new CILASTCallInstructionNodeBuilder();
            _loadStringInstructionNodeBuilder = new CILASTLoadStringInstructionNodeBuilder();
            _popInstructionNodeBuilder = new CILASTPopInstructionNodeBuilder();
            _retInstructionNodeBuilder = new CILASTRetInstructionNodeBuilder();
        }

        public CILInstruction BuildNode(ParseTreeNode parseNode)
        {
            var callInstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsCallInstructionNode());
            if (callInstructionParseNode != null)
                return _callInstructionNodeBuilder.BuildNode(callInstructionParseNode);

            var loadStringInstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadStringInstructionNode());
            if (loadStringInstructionParseNode != null)
                return _loadStringInstructionNodeBuilder.BuildNode(loadStringInstructionParseNode);

            var popInstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsPopInstructionNode());
            if (popInstructionParseNode != null)
                return _popInstructionNodeBuilder.BuildNode(popInstructionParseNode);

            var retInstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsRetInstructionNode());
            if (retInstructionParseNode != null)
                return _retInstructionNodeBuilder.BuildNode(retInstructionParseNode);

            var firstInstructionParseNode = parseNode.ChildNodes.First();
            throw new ArgumentException($"Cannot recognize instruction '{firstInstructionParseNode.Term.Name}'.");
        }
    }
}
