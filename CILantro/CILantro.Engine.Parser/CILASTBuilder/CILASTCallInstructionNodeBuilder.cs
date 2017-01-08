using CILantro.Engine.Parser.CILASTNodes;
using CILantro.Shared.CILSimpleTypes;
using Irony.Parsing;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTCallInstructionNodeBuilder : ICILASTNodeBuilder<CILCallInstruction>
    {
        private readonly CILSimpleTypeBuilder _simpleTypeBuilder;

        public CILASTCallInstructionNodeBuilder()
        {
            _simpleTypeBuilder = new CILSimpleTypeBuilder();
        }

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
            var argumentTypes = new List<CILSimpleType>();
            foreach(var argumentTypeParseNode in argumentTypesParseNode.ChildNodes)
            {
                var simpleTypeIdentifierParseNode = argumentTypeParseNode.ChildNodes.First(cn => cn.IsSimpleTypeIdentifierNode());
                var argumentType = _simpleTypeBuilder.BuildSimpleType(simpleTypeIdentifierParseNode);
                argumentTypes.Add(argumentType);
            }

            var resultNode = new CILCallInstruction
            {
                MethodAssemblyName = methodAssemblyName,
                MethodClassName = methodClassName,
                MethodName = methodName,
                ArgumentTypes = argumentTypes
            };

            return resultNode;
        }
    }
}
