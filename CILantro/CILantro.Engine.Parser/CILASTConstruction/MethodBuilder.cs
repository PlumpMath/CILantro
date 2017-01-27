using CILantro.Engine.AST.ASTNodes;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTConstruction
{
    public class MethodBuilder : CILASTNodeBuilder<CILMethod>
    {
        private InstructionBuilder _instructionBuilder;

        public MethodBuilder()
        {
            _instructionBuilder = new InstructionBuilder();
        }

        public override CILMethod BuildNode(ParseTreeNode node)
        {
            var cilInstructions = new List<CILInstruction>();

            var methodDeclarationsNode = node.GetChildMethodDeclarationsNode();
            while(methodDeclarationsNode != null && methodDeclarationsNode.ChildNodes.Any())
            {
                var methodDeclarationNode = methodDeclarationsNode.GetChildMethodDeclarationNode();
                var instructionNode = methodDeclarationNode.GetChildInstructionNode();

                if (instructionNode != null)
                {
                    var instruction = _instructionBuilder.BuildNode(instructionNode);
                    cilInstructions.Add(instruction);
                }

                methodDeclarationsNode = methodDeclarationsNode.GetChildMethodDeclarationsNode();
            }

            cilInstructions.Reverse();

            var resultMethod = new CILMethod
            {
                Instructions = cilInstructions
            };

            foreach(var cilInstruction in cilInstructions)
            {
                cilInstruction.Method = resultMethod;
            }

            return resultMethod;
        }
    }
}
