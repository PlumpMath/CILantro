using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTAssemblyNodeBuilder : ICILASTNodeBuilder<CILAssembly>
    {
        public CILAssembly BuildNode(ParseTreeNode parseNode)
        {
            var identifierParseNode = parseNode.ChildNodes.First(cn => cn.IsIdentifierNode());
            var assemblyName = identifierParseNode.Token.ValueString;

            var optionalExternKeywordParseNode = parseNode.ChildNodes.First(cn => cn.IsOptionalExternKeywordNode());
            var isAssemblyExternal = optionalExternKeywordParseNode.ChildNodes.Any(cn => cn.IsExternKeywordNode());

            var resultNode = new CILAssembly
            {
                Name = assemblyName,
                IsExternal = isAssemblyExternal
            };

            return resultNode;
        }
    }
}
