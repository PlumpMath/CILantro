using System;
using CILantro.Engine.Parser.CILAST;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTProgramRootNodeBuilder : ICILASTNodeBuilder<CILProgramRoot>
    {
        private readonly CILASTAssemblyNodeBuilder _assemblyNodeBuilder;
        private readonly CILASTClassNodeBuilder _classNodeBuilder;

        public CILASTProgramRootNodeBuilder()
        {
            _assemblyNodeBuilder = new CILASTAssemblyNodeBuilder();
            _classNodeBuilder = new CILASTClassNodeBuilder();
        }

        public CILProgramRoot BuildNode(ParseTreeNode parseNode)
        {
            var assemblyDeclarationParseNode = parseNode.ChildNodes.First(cn => cn.IsAssemblyDeclarationNode());
            var assemblyNode = _assemblyNodeBuilder.BuildNode(assemblyDeclarationParseNode) as CILAssembly;

            var classDeclarationParseNode = parseNode.ChildNodes.First(cn => cn.IsClassDeclarationNode());
            var classNode = _classNodeBuilder.BuildNode(classDeclarationParseNode) as CILClass;

            var resultNode = new CILProgramRoot
            {
                Assembly = assemblyNode,
                Class = classNode
            };

            return resultNode;
        }
    }
}
