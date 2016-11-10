using CILantro.Engine.Parser.CILAST;
using Irony.Parsing;
using System;

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
                var programNode = new CILProgramNode();
                return programNode;
            }

            throw new ArgumentException("Cannot build AST node based on given ParseTreeNode.");
        }
    }
}
