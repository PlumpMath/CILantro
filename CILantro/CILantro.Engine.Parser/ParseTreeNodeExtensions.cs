using Irony.Parsing;

namespace CILantro.Engine.Parser
{
    public static class ParseTreeNodeExtensions
    {
        public static bool IsEntryPointNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals(".entrypoint");
        }

        public static bool IsMethodDeclarationBlockNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("methodDeclarationBlock");
        }

        public static bool IsMethodDeclarationNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("methodDeclaration");
        }

        public static bool IsClassDeclarationBlockNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("classDeclarationBlock");
        }

        public static bool IsClassDeclarationNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("classDeclaration");
        }

        public static bool IsAssemblyDeclarationNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("assemblyDeclaration");
        }
    }
}
