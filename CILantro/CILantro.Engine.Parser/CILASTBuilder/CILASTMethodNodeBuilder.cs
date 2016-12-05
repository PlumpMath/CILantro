using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTMethodNodeBuilder : ICILASTNodeBuilder<CILMethod>
    {
        private readonly CILASTInstructionNodeBuilder _instructionNodeBuilder;

        public CILASTMethodNodeBuilder()
        {
            _instructionNodeBuilder = new CILASTInstructionNodeBuilder();
        }

        public CILMethod BuildNode(ParseTreeNode parseNode)
        {
            var methodDeclarationBlockParseNode = parseNode.ChildNodes.First(cn => cn.IsMethodDeclarationBlockNode());

            var isEntryPoint = methodDeclarationBlockParseNode.ChildNodes.Any(cn => cn.IsEntryPointNode());

            var instructions = new List<CILInstruction>();
            var instructionsSequenceParseNode = methodDeclarationBlockParseNode.ChildNodes.FirstOrDefault(cn => cn.IsInstructionsSequenceNode());
            while(instructionsSequenceParseNode != null)
            {
                var instructionParseNode = instructionsSequenceParseNode.ChildNodes.First(cn => cn.IsInstructionNode());
                var instruction = _instructionNodeBuilder.BuildNode(instructionParseNode);
                instructions.Add(instruction);

                instructionsSequenceParseNode = instructionsSequenceParseNode.ChildNodes.FirstOrDefault(cn => cn.IsInstructionsSequenceNode());
            }

            var resultNode = new CILMethod
            {
                IsEntryPoint = isEntryPoint,
                Instructions = instructions
            };

            return resultNode;
        }
    }
}
