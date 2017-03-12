﻿using Irony.Parsing;

namespace CILantro.Engine.Parser
{
    internal class CILGrammar : Grammar
    {
        public CILGrammar()
        {
            // punctuation

            var colon = ToTerm(":", GrammarNames.Colon);
            var dot = ToTerm(".", GrammarNames.Dot);
            var comma = ToTerm(",", GrammarNames.Comma);
            var plus = ToTerm("+", GrammarNames.Plus);
            var leftBrace = ToTerm("{", GrammarNames.LeftBrace);
            var rightBrace = ToTerm("}", GrammarNames.RightBrace);
            var leftParenthesis = ToTerm("(", GrammarNames.LeftParenthesis);
            var rightParenthesis = ToTerm(")", GrammarNames.RightParenthesis);
            var leftSquareBracket = ToTerm("[", GrammarNames.LeftSquareBracket);
            var rightSquareBracket = ToTerm("]", GrammarNames.RightSquareBracket);

            // tokens

            var callToken = ToTerm("call", GrammarNames.CallToken);
            var cilToken = ToTerm("cil", GrammarNames.CilToken);
            var dotAssemblyToken = ToTerm(".assembly", GrammarNames.DotAssemblyToken);
            var dotClassToken = ToTerm(".class", GrammarNames.DotClassToken);
            var dotEntrypointToken = ToTerm(".entrypoint", GrammarNames.DotEntrypointToken);
            var dotMethodToken = ToTerm(".method", GrammarNames.DotMethodToken);
            var externToken = ToTerm("extern", GrammarNames.ExternToken);
            var int32Token = ToTerm("int32", GrammarNames.Int32Token);
            var ldci40Token = ToTerm("ldc.i4.0", GrammarNames.Ldci40Token);
            var ldci41Token = ToTerm("ldc.i4.1", GrammarNames.Ldci41Token);
            var ldci42Token = ToTerm("ldc.i4.2", GrammarNames.Ldci42Token);
            var ldstrToken = ToTerm("ldstr", GrammarNames.LdstrToken);
            var managedToken = ToTerm("managed", GrammarNames.ManagedToken);
            var popToken = ToTerm("pop", GrammarNames.PopToken);
            var retToken = ToTerm("ret", GrammarNames.RetToken);
            var staticToken = ToTerm("static", GrammarNames.StaticToken);
            var stringToken = ToTerm("string", GrammarNames.StringToken);
            var valuetypeToken = ToTerm("valuetype", GrammarNames.ValuetypeToken);
            var voidToken = ToTerm("void", GrammarNames.VoidToken);

            // lexical tokens

            var identifier = new IdentifierTerminal(GrammarNames.Identifier);

            var quotedString = new StringLiteral(GrammarNames.QuotedString, "\"");

            // productions

            var id = new NonTerminal(GrammarNames.Id);
            id.Rule = identifier;

            var name = new NonTerminal(GrammarNames.Name);
            name.Rule =
                id |
                name + dot + name;

            var complexQuotedString = new NonTerminal(GrammarNames.ComplexQuotedString);
            complexQuotedString.Rule =
                quotedString |
                complexQuotedString + plus + quotedString;

            var slashedName = new NonTerminal(GrammarNames.SlashedName);
            slashedName.Rule = name;

            var methodName = new NonTerminal(GrammarNames.MethodName);
            methodName.Rule = name;

            var className = new NonTerminal(GrammarNames.ClassName);
            className.Rule = leftSquareBracket + name + rightSquareBracket + slashedName; 

            var type = new NonTerminal(GrammarNames.Type);
            type.Rule =
                stringToken |
                valuetypeToken + className |
                voidToken |
                int32Token;

            var typeSpecification = new NonTerminal(GrammarNames.TypeSpecification);
            typeSpecification.Rule =
                className |
                leftSquareBracket + name + rightSquareBracket;

            var callKind = new NonTerminal(GrammarNames.CallKind);
            callKind.Rule = Empty;

            var callConventions = new NonTerminal(GrammarNames.CallConventions);
            callConventions.Rule = callKind;

            var paramAttributes = new NonTerminal(GrammarNames.ParamAttributes);
            paramAttributes.Rule = Empty;

            var signatureArgument = new NonTerminal(GrammarNames.SignatureArgument);
            signatureArgument.Rule = paramAttributes + type;

            var signatureArguments1 = new NonTerminal(GrammarNames.SignatureArguments1);
            signatureArguments1.Rule =
                signatureArgument |
                signatureArguments1 + comma + signatureArgument;

            var signatureArguments0 = new NonTerminal(GrammarNames.SignatureArguments0);
            signatureArguments0.Rule =
                Empty |
                signatureArguments1;

            var instructionNone = new NonTerminal(GrammarNames.InstructionNone);
            instructionNone.Rule =
                ldci40Token |
                ldci41Token |
                ldci42Token |
                popToken |
                retToken;

            var instructionMethod = new NonTerminal(GrammarNames.InstructionMethod);
            instructionMethod.Rule = callToken;

            var instructionString = new NonTerminal(GrammarNames.InstructionString);
            instructionString.Rule = ldstrToken;

            var instruction = new NonTerminal(GrammarNames.Instruction);
            instruction.Rule =
                instructionNone |
                instructionMethod + callConventions + type + typeSpecification + colon + colon + methodName + leftParenthesis + signatureArguments0 + rightParenthesis |
                instructionMethod + callConventions + type + methodName + leftParenthesis + signatureArguments0 + rightParenthesis |
                instructionString + complexQuotedString;

            var implementationAttributes = new NonTerminal(GrammarNames.ImplementationAttributes);
            implementationAttributes.Rule =
                Empty |
                implementationAttributes + cilToken |
                implementationAttributes + managedToken;

            var methodAttributes = new NonTerminal(GrammarNames.MethodAttributes);
            methodAttributes.Rule =
                Empty |
                methodAttributes + staticToken;

            var methodHead = new NonTerminal(GrammarNames.MethodHead);
            methodHead.Rule = dotMethodToken + methodAttributes + callConventions + paramAttributes + type + methodName + leftParenthesis + signatureArguments0 + rightParenthesis + implementationAttributes + leftBrace;

            var methodDeclaration = new NonTerminal(GrammarNames.MethodDeclaration);
            methodDeclaration.Rule =
                dotEntrypointToken |
                instruction;

            var methodDeclarations = new NonTerminal(GrammarNames.MethodDeclarations);
            methodDeclarations.Rule =
                Empty |
                methodDeclarations + methodDeclaration;

            var extendsClause = new NonTerminal(GrammarNames.ExtendsClause);
            extendsClause.Rule = Empty;

            var implementsClause = new NonTerminal(GrammarNames.ImplementsClause);
            implementsClause.Rule = Empty;

            var classAttributes = new NonTerminal(GrammarNames.ClassAttributes);
            classAttributes.Rule = Empty;

            var classHead = new NonTerminal(GrammarNames.ClassHead);
            classHead.Rule = dotClassToken + classAttributes + name + extendsClause + implementsClause;

            var classDeclaration = new NonTerminal(GrammarNames.ClassDeclaration);
            classDeclaration.Rule = methodHead + methodDeclarations + rightBrace;

            var classDeclarations = new NonTerminal(GrammarNames.ClassDeclarations);
            classDeclarations.Rule =
                Empty |
                classDeclarations + classDeclaration;

            var assemblyAttributes = new NonTerminal(GrammarNames.AssemblyAttributes);
            assemblyAttributes.Rule = Empty;

            var assemblyHead = new NonTerminal(GrammarNames.AssemblyHead);
            assemblyHead.Rule = dotAssemblyToken + assemblyAttributes + name;

            var assemblyDeclarations = new NonTerminal(GrammarNames.AssemblyDeclarations);
            assemblyDeclarations.Rule = Empty;

            var assemblyRefHead = new NonTerminal(GrammarNames.AssemblyRefHead);
            assemblyRefHead.Rule = dotAssemblyToken + externToken + name;

            var assemblyRefDeclarations = new NonTerminal(GrammarNames.AssemblyRefDeclarations);
            assemblyRefDeclarations.Rule = Empty;

            var declaration = new NonTerminal(GrammarNames.Declaration);
            declaration.Rule =
                classHead + leftBrace + classDeclarations + rightBrace |
                assemblyHead + leftBrace + assemblyDeclarations + rightBrace |
                assemblyRefHead + leftBrace + assemblyRefDeclarations + rightBrace;

            var declarations = new NonTerminal(GrammarNames.Declarations);
            declarations.Rule =
                Empty |
                declarations + declaration;

            Root = declarations;
        }
    }
}
