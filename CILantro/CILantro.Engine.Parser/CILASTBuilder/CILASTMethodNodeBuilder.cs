using CILantro.Engine.Parser.CILAST;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTMethodNodeBuilder : CILASTNodeBuilder
    {
        public override CILASTNode BuildNode(ParseTreeNode parseNode)
        {
            var methodDeclarationBlockParseNode = parseNode.ChildNodes.First(cn => cn.IsMethodDeclarationBlockNode());

            var isEntryPoint = methodDeclarationBlockParseNode.ChildNodes.Any(cn => cn.IsEntryPointNode());

            var resultNode = new CILMethod
            {
                IsEntryPoint = isEntryPoint
            };

            return resultNode;
        }
    }
}
