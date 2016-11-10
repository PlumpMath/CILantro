using CILantro.Engine.Parser.CILAST;
using Irony.Parsing;
using System;
using System.Linq;

namespace CILantro.Engine.Parser
{
    internal class CILAbstractSyntaxTreeBuilder
    {
        public CILProgram BuildTree(ParseTree parseTree)
        {
            var rootNode = BuildNode(parseTree.Root);

            return new CILProgram
            {
                Root = rootNode
            };
        }

        public CILASTNode BuildNode(ParseTreeNode parseNode)
        {
            if (parseNode.Term.Name.Equals("program"))
            {
                var assemblyDeclaration = parseNode.ChildNodes.First(pn => pn.Term.Name.Equals("assemblyDeclaration"));
                var assemblyDeclarationNode = BuildNode(assemblyDeclaration) as CILAssembly;

                var classDeclaration = parseNode.ChildNodes.First(cn => cn.Term.Name.Equals("classDeclaration"));
                var classDeclarationNode = BuildNode(classDeclaration) as CILClass;

                var programNode = new CILProgramRoot
                {
                    Assembly = assemblyDeclarationNode,
                    Class = classDeclarationNode
                };

                return programNode;
            }

            if(parseNode.Term.Name.Equals("assemblyDeclaration"))
            {
                var assemblyDeclarationNode = new CILAssembly();

                return assemblyDeclarationNode;
            }

            if(parseNode.Term.Name.Equals("classDeclaration"))
            {
                var classDeclarationBlock = parseNode.ChildNodes.First(cn => cn.Term.Name.Equals("classDeclarationBlock"));

                var methodDeclaration = classDeclarationBlock.ChildNodes.First(pn => pn.Term.Name.Equals("methodDeclaration"));
                var methodDeclarationNode = BuildNode(methodDeclaration) as CILMethod;

                var classDeclarationNode = new CILClass
                {
                    Method = methodDeclarationNode
                };

                return classDeclarationNode;
            }

            if(parseNode.Term.Name.Equals("methodDeclaration"))
            {
                var methodDeclarationBlock = parseNode.ChildNodes.First(cn => cn.Term.Name.Equals("methodDeclarationBlock"));

                var isEntryPoint = methodDeclarationBlock.ChildNodes.Any(cn => cn.Term.Name.Equals(".entrypoint"));

                var methodDeclarationNode = new CILMethod
                {
                    IsEntryPoint = isEntryPoint
                };

                return methodDeclarationNode;
            }

            throw new ArgumentException("Cannot build AST node based on given ParseTreeNode.");
        }
    }
}
