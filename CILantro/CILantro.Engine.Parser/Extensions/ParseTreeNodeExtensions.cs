using Irony.Parsing;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Engine.Parser.Extensions
{
    public static class ParseTreeNodeExtensions
    {
        public static bool IsClassDeclarationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ClassDeclaration);
        public static bool IsClassDeclarationsNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ClassDeclarations);
        public static bool IsClassHeadDeclarationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ClassHead);
        public static bool IsClassNameNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ClassName);
        public static bool IsComplexQuotedStringNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.ComplexQuotedString);
        public static bool IsDeclarationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Declaration);
        public static bool IsIdNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Id);
        public static bool IsInstructionNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Instruction);
        public static bool IsInstructionMethodNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.InstructionMethod);
        public static bool IsInstructionStringNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.InstructionString);
        public static bool IsInstructionNoneNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.InstructionNone);
        public static bool IsMethodDeclarationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.MethodDeclaration);
        public static bool IsMethodDeclarationsNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.MethodDeclarations);
        public static bool IsMethodNameNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.MethodName);
        public static bool IsNameNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Name);
        public static bool IsPopTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.PopToken);
        public static bool IsQuotedStringNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.QuotedString);
        public static bool IsRetTokenNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.RetToken);
        public static bool IsSignatureArgumentNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.SignatureArgument);
        public static bool IsSignatureArguments0Node(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.SignatureArguments0);
        public static bool IsSignatureArguments1Node(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.SignatureArguments1);
        public static bool IsSlashedNameNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.SlashedName);
        public static bool IsTypeNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.Type);
        public static bool IsTypeSpecificationNode(this ParseTreeNode node) => node.Term.Name.Equals(GrammarNames.TypeSpecification);

        public static ParseTreeNode GetChildClassDeclarationNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsClassDeclarationNode());
        public static ParseTreeNode GetChildClassDeclarationsNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsClassDeclarationsNode());
        public static ParseTreeNode GetChildClassHeadNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsClassHeadDeclarationNode());
        public static ParseTreeNode GetChildClassNameNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsClassNameNode());
        public static ParseTreeNode GetChildComplexQuotedStringNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsComplexQuotedStringNode());
        public static ParseTreeNode GetChildDeclarationNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsDeclarationNode());
        public static ParseTreeNode GetChildIdNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsIdNode());
        public static ParseTreeNode GetChildInstructionNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionNode());
        public static ParseTreeNode GetChildInstructionMethodNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionMethodNode());
        public static ParseTreeNode GetChildInstructionStringNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionStringNode());
        public static ParseTreeNode GetChildInstructionNoneNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsInstructionNoneNode());
        public static ParseTreeNode GetChildMethodDeclarationNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsMethodDeclarationNode());
        public static ParseTreeNode GetChildMethodDeclarationsNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsMethodDeclarationsNode());
        public static ParseTreeNode GetChildMethodNameNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsMethodNameNode());
        public static ParseTreeNode GetChildNameNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsNameNode());
        public static ParseTreeNode GetChildPopTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsPopTokenNode());
        public static ParseTreeNode GetChildQuotedStringNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsQuotedStringNode());
        public static ParseTreeNode GetChildRetTokenNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsRetTokenNode());
        public static ParseTreeNode GetChildSignatureArgumentNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsSignatureArgumentNode());
        public static ParseTreeNode GetChildSignatureArguments0Node(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsSignatureArguments0Node());
        public static ParseTreeNode GetChildSignatureArguments1Node(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsSignatureArguments1Node());
        public static ParseTreeNode GetChildSlashedNameNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsSlashedNameNode());
        public static ParseTreeNode GetChildTypeNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsTypeNode());
        public static ParseTreeNode GetChildTypeSpecificationNode(this ParseTreeNode node) => node.ChildNodes.FirstOrDefault(cn => cn.IsTypeSpecificationNode());

        public static IEnumerable<ParseTreeNode> GetAllChildNameNodes(this ParseTreeNode node) => node.ChildNodes.Where(cn => cn.IsNameNode());
    }
}
