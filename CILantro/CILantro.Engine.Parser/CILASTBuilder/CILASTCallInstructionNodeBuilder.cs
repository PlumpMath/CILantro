using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTCallInstructionNodeBuilder : ICILASTNodeBuilder<CILCallInstruction>
    {
        public CILCallInstruction BuildNode(ParseTreeNode parseNode)
        {
            var methodDefinitionParseNode = parseNode.ChildNodes.First(cn => cn.IsMethodDefinitionNode());

            var methodNamespaceIdentifierParseNode = methodDefinitionParseNode.ChildNodes.First(cn => cn.IsNamespaceIdentifierNode());
            var methodAssemblyName = string.Join("", methodNamespaceIdentifierParseNode.ChildNodes.Select(cn => cn.Token.ValueString));

            var methodIdentifierParseNode = methodDefinitionParseNode.ChildNodes.First(cn => cn.IsMethodIdentifierNode());

            var methodClassName = string.Empty;
            var typeIdentifierParseNode = methodIdentifierParseNode.ChildNodes.FirstOrDefault(cn => cn.IsTypeIdentifierNode());
            while(typeIdentifierParseNode != null)
            {
                if (!string.IsNullOrEmpty(methodClassName)) methodClassName += ".";

                var identifierParseNode = typeIdentifierParseNode.ChildNodes.FirstOrDefault(cn => cn.IsIdentifierNode());
                methodClassName += identifierParseNode.Token.ValueString;

                typeIdentifierParseNode = typeIdentifierParseNode.ChildNodes.FirstOrDefault(cn => cn.IsTypeIdentifierNode());
            }

            var methodNameIdentifierParseNode = methodIdentifierParseNode.ChildNodes.First(cn => cn.IsIdentifierNode());
            var methodName = methodNameIdentifierParseNode.Token.ValueString;

            var argumentTypesParseNode = methodIdentifierParseNode.ChildNodes.First(cn => cn.IsArgumentTypesNode());
            var argumentsCount = argumentTypesParseNode.ChildNodes.Count;

            var resultNode = new CILCallInstruction
            {
                MethodAssemblyName = methodAssemblyName,
                MethodClassName = methodClassName,
                MethodName = methodName,
                ArgumentsCount = argumentsCount
            };

            return resultNode;
        }
    }
}
