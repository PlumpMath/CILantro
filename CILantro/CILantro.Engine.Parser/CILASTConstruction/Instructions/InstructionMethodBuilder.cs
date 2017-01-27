using CILantro.Engine.AST.ASTNodes.Instructions;
using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionMethodBuilder : CILASTNodeBuilder<InstructionMethod>
    {
        public override InstructionMethod BuildNode(ParseTreeNode node)
        {
            string assemblyName = null;
            string className = null;
            string methodName = null;

            var typeSpecificationNode = node.GetChildTypeSpecificationNode();
            var classNameNode = typeSpecificationNode.GetChildClassNameNode();

            var classNameNameNode = classNameNode.GetChildNameNode();
            var classNameIdNode = classNameNameNode.GetChildIdNode();
            assemblyName = classNameIdNode.ChildNodes.First().Token.ValueString;

            var slashedNameNode = classNameNode.GetChildSlashedNameNode();
            var slashedNameNameNode = slashedNameNode.GetChildNameNode();
            className = string.Join(".", slashedNameNameNode.GetAllChildNameNodes().Select(n => n.GetChildIdNode().ChildNodes.First().Token.ValueString));

            var methodNameNode = node.GetChildMethodNameNode();
            var methodNameNameNode = methodNameNode.GetChildNameNode();
            var methodNameIdNode = methodNameNameNode.GetChildIdNode();
            methodName = methodNameIdNode.ChildNodes.First().Token.ValueString;

            return new CallInstruction
            {
                AssemblyName = assemblyName,
                ClassName = className,
                MethodName = methodName
            };
        }
    }
}
