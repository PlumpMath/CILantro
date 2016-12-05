using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;
using System.Collections.Generic;
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
            var assemblies = new List<CILAssembly>();
            var assemblyDeclarationsParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsAssemblyDeclarationsNode());
            while(assemblyDeclarationsParseNode != null)
            {
                var assemblyDeclarationParseNode = assemblyDeclarationsParseNode.ChildNodes.First(cn => cn.IsAssemblyDeclarationNode());
                var assemblyNode = _assemblyNodeBuilder.BuildNode(assemblyDeclarationParseNode) as CILAssembly;
                assemblies.Add(assemblyNode);

                assemblyDeclarationsParseNode = assemblyDeclarationsParseNode.ChildNodes.FirstOrDefault(cn => cn.IsAssemblyDeclarationsNode());
            }

            var classDeclarationParseNode = parseNode.ChildNodes.First(cn => cn.IsClassDeclarationNode());
            var classNode = _classNodeBuilder.BuildNode(classDeclarationParseNode) as CILClass;

            var resultNode = new CILProgramRoot
            {
                Assemblies = assemblies,
                Class = classNode
            };

            return resultNode;
        }
    }
}
