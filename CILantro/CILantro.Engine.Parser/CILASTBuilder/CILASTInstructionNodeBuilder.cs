using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;
using System;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTInstructionNodeBuilder : ICILASTNodeBuilder<CILInstruction>
    {
        private readonly CILASTCallInstructionNodeBuilder _callInstructionNodeBuilder;
        private readonly CILASTLoadInt32InstructionNodeBuilder _loadInt32InstructionNodeBuilder;
        private readonly CILASTLoadStringInstructionNodeBuilder _loadStringInstructionNodeBuilder;
        private readonly CILASTPopInstructionNodeBuilder _popInstructionNodeBuilder;
        private readonly CILASTRetInstructionNodeBuilder _retInstructionNodeBuilder;

        public CILASTInstructionNodeBuilder()
        {
            _callInstructionNodeBuilder = new CILASTCallInstructionNodeBuilder();
            _loadInt32InstructionNodeBuilder = new CILASTLoadInt32InstructionNodeBuilder();
            _loadStringInstructionNodeBuilder = new CILASTLoadStringInstructionNodeBuilder();
            _popInstructionNodeBuilder = new CILASTPopInstructionNodeBuilder();
            _retInstructionNodeBuilder = new CILASTRetInstructionNodeBuilder();
        }

        public CILInstruction BuildNode(ParseTreeNode parseNode)
        {
            var callInstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsCallInstructionNode());
            if (callInstructionParseNode != null)
                return _callInstructionNodeBuilder.BuildNode(callInstructionParseNode);

            var loadInt320InstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt320InstructionNode());
            if (loadInt320InstructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt320InstructionParseNode);

            var loadInt321InstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt321InstructionNode());
            if (loadInt321InstructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt321InstructionParseNode);

            var loadInt322InstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt322InstructionNode());
            if (loadInt322InstructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt322InstructionParseNode);

            var loadInt323InstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt323InstructionNode());
            if (loadInt323InstructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt323InstructionParseNode);

            var loadInt324InstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt324InstructionNode());
            if (loadInt324InstructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt324InstructionParseNode);

            var loadInt325InstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt325InstructionNode());
            if (loadInt325InstructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt325InstructionParseNode);

            var loadInt326InstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt326InstructionNode());
            if (loadInt326InstructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt326InstructionParseNode);

            var loadInt327InstructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt327InstructionNode());
            if (loadInt327InstructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt327InstructionParseNode);

            var loadInt328InsructionParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsLoadInt328InstructionNode());
            if (loadInt328InsructionParseNode != null)
                return _loadInt32InstructionNodeBuilder.BuildNode(loadInt328InsructionParseNode);

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
