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

        public static bool IsInstructionsSequenceNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("instructionsSequence");
        }

        public static bool IsInstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("instruction");
        }

        public static bool IsCallInstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("callInstruction");
        }

        public static bool IsLoadStringInstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("ldstrInstruction");
        }

        public static bool IsPopInstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("popInstruction");
        }

        public static bool IsRetInstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("retInstruction");
        }

        public static bool IsMethodDefinitionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("methodDefinition");
        }

        public static bool IsNamespaceIdentifierNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("namespaceIdentifier");
        }

        public static bool IsAssemblyDeclarationsNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("assemblyDeclarations");
        }

        public static bool IsIdentifierNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("identifier");
        }

        public static bool IsOptionalExternKeywordNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("optionalExternKeyword");
        }

        public static bool IsExternKeywordNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("externKeyword");
        }

        public static bool IsMethodIdentifierNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("methodIdentifier");
        }

        public static bool IsTypeIdentifierNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("typeIdentifier");
        }

        public static bool IsArgumentTypesNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("argumentTypes");
        }

        public static bool IsStringValueNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("stringValue");
        }

        public static bool IsLoadInt320InstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("ldci40Instruction");
        }

        public static bool IsSimpleTypeIdentifierNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("simpleTypeIdentifier");
        }

        public static bool IsStringTypeIdentifierNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("stringTypeIdentifier");
        }

        public static bool IsInt32TypeIdentifierNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("int32TypeIdentifier");
        }

        public static bool IsLoadInt321InstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("ldci41Instruction");
        }

        public static bool IsLoadInt322InstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("ldci42Instruction");
        }

        public static bool IsLoadInt323InstructionNode(this ParseTreeNode node)
        {
            return node.Term.Name.Equals("ldci43Instruction");
        }
    }
}
