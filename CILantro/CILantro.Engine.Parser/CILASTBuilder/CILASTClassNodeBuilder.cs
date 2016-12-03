using System;
using CILantro.Engine.Parser.CILAST;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTClassNodeBuilder : ICILASTNodeBuilder<CILClass>
    {
        private readonly CILASTMethodNodeBuilder _methodNodeBuilder;

        public CILASTClassNodeBuilder()
        {
            _methodNodeBuilder = new CILASTMethodNodeBuilder();
        }

        public CILClass BuildNode(ParseTreeNode parseNode)
        {
            var classDeclarationBlockParseNode = parseNode.ChildNodes.First(cn => cn.IsClassDeclarationBlockNode());

            var methodDeclarationParseNode = classDeclarationBlockParseNode.ChildNodes.First(cn => cn.IsMethodDeclarationNode());
            var methodNode = _methodNodeBuilder.BuildNode(methodDeclarationParseNode) as CILMethod;

            var resultNode = new CILClass
            {
                Method = methodNode
            };

            return resultNode;
        }
    }
}
