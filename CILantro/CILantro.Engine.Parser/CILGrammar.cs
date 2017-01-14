using Irony.Parsing;

namespace CILantro.Engine.Parser
{
    internal class CILGrammar : Grammar
    {
        public CILGrammar()
        {
            // declaration keywords

            var assemblyDeclKeyword = ToTerm(".assembly", "assemblyDeclKeyword");
            var classDeclKeyword = ToTerm(".class", "classDeclKeyword");
            var entryPointKeyword = ToTerm(".entrypoint", "entryPointKeyword");
            var methodDeclKeyword = ToTerm(".method", "methodDeclKeyword");

            // keywords

            var callKeyword = ToTerm("call", "callKeyword");
            var cilKeyword = ToTerm("cil", "cilKeyword");
            var externKeyword = ToTerm("extern", "externKeyword");
            var int32Keyword = ToTerm("int32", "int32Keyword");
            var ldci40Keyword = ToTerm("ldc.i4.0", "ldci40Keyword");
            var ldci41Keyword = ToTerm("ldc.i4.1", "ldci41Keyword");
            var ldci42Keyword = ToTerm("ldc.i4.2", "ldci42Keyword");
            var ldci43Keyword = ToTerm("ldc.i4.3", "ldci43Keyword");
            var ldci44Keyword = ToTerm("ldc.i4.4", "ldci44Keyword");
            var ldci45Keyword = ToTerm("ldc.i4.5", "ldci45Keyword");
            var ldci46Keyword = ToTerm("ldc.i4.6", "ldci46Keyword");
            var ldci47Keyword = ToTerm("ldc.i4.7", "ldci47Keyword");
            var ldci48Keyword = ToTerm("ldc.i4.8", "ldci48Keyword");
            var ldci4m1Keyword = ToTerm("ldc.i4.m1", "ldci4m1Keyword");
            var ldci4M1Keyword = ToTerm("ldc.i4.M1", "ldci4M1Keyword");
            var ldci4sKeyword = ToTerm("ldc.i4.s", "ldci4sKeyword");
            var ldstrKeyword = ToTerm("ldstr", "ldstrKeyword");
            var managedKeyword = ToTerm("managed", "managedKeyword");
            var popKeyword = ToTerm("pop", "popKeyword");
            var retKeyword = ToTerm("ret", "retKeyword");
            var staticKeyword = ToTerm("static", "staticKeyword");
            var stringKeyword = ToTerm("string", "stringKeyword");
            var valuetypeKeyword = ToTerm("valuetype", "valuetypeKeyword");
            var voidKeyword = ToTerm("void", "voidKeyword");

            // optional keywords

            var optionalExternKeyword = new NonTerminal("optionalExternKeyword");
            optionalExternKeyword.Rule = externKeyword | Empty;

            // punctuation

            var dot = ToTerm(".");
            var comma = ToTerm(",");
            var colon = ToTerm(":");
            var leftBrace = ToTerm("{");
            var rightBrace = ToTerm("}");
            var leftParenthesis = ToTerm("(");
            var rightParenthesis = ToTerm(")");
            var leftBracket = ToTerm("[");
            var rightBracket = ToTerm("]");

            // simple types

            var int32TypeIdentifier = new NonTerminal("int32TypeIdentifier");
            int32TypeIdentifier.Rule = int32Keyword;

            var stringTypeIdentifier = new NonTerminal("stringTypeIdentifier");
            stringTypeIdentifier.Rule = stringKeyword;

            var simpleTypeIdentifier = new NonTerminal("simpleTypeIdentifier");
            simpleTypeIdentifier.Rule = int32TypeIdentifier | stringTypeIdentifier;

            // values

            var int8Value = new NumberLiteral("int8Value", NumberOptions.AllowSign);

            var stringValue = new StringLiteral("stringValue", "\"");

            // arguments

            var argumentType = new NonTerminal("argumentType");
            argumentType.Rule = simpleTypeIdentifier;

            var argumentTypes = new NonTerminal("argumentTypes");
            argumentTypes.Rule = Empty | argumentType | (argumentType + comma + argumentTypes);

            // identifiers

            var identifier = new IdentifierTerminal("identifier");

            var namespaceIdentifier = new NonTerminal("namespaceIdentifier");
            namespaceIdentifier.Rule = identifier | (identifier + dot + namespaceIdentifier);

            var typeIdentifier = new NonTerminal("typeIdentifier");
            typeIdentifier.Rule = identifier | (identifier + dot + typeIdentifier);

            var methodIdentifier = new NonTerminal("methodIdentifier");
            methodIdentifier.Rule = typeIdentifier + colon + colon + identifier + leftParenthesis + argumentTypes + rightParenthesis;

            // definitions

            var returnTypeDefinition = new NonTerminal("returnTypeDefinition");
            returnTypeDefinition.Rule = leftBracket + namespaceIdentifier + rightBracket + typeIdentifier;

            var methodDefinition = new NonTerminal("methodDefinition");
            methodDefinition.Rule = leftBracket + namespaceIdentifier + rightBracket + methodIdentifier;

            // instructions

            var callInstruction = new NonTerminal("callInstruction");
            callInstruction.Rule = callKeyword + ((valuetypeKeyword + returnTypeDefinition) | voidKeyword) + methodDefinition;

            var ldci40Instruction = new NonTerminal("ldci40Instruction");
            ldci40Instruction.Rule = ldci40Keyword;

            var ldci41Instruction = new NonTerminal("ldci41Instruction");
            ldci41Instruction.Rule = ldci41Keyword;

            var ldci42Instruction = new NonTerminal("ldci42Instruction");
            ldci42Instruction.Rule = ldci42Keyword;

            var ldci43Instruction = new NonTerminal("ldci43Instruction");
            ldci43Instruction.Rule = ldci43Keyword;

            var ldci44Instruction = new NonTerminal("ldci44Instruction");
            ldci44Instruction.Rule = ldci44Keyword;

            var ldci45Instruction = new NonTerminal("ldci45Instruction");
            ldci45Instruction.Rule = ldci45Keyword;

            var ldci46Instruction = new NonTerminal("ldci46Instruction");
            ldci46Instruction.Rule = ldci46Keyword;

            var ldci47Instruction = new NonTerminal("ldci47Instruction");
            ldci47Instruction.Rule = ldci47Keyword;

            var ldci48Instruction = new NonTerminal("ldci48Instruction");
            ldci48Instruction.Rule = ldci48Keyword;

            var ldci4m1Instruction = new NonTerminal("ldci4m1Instruction");
            ldci4m1Instruction.Rule = ldci4m1Keyword | ldci4M1Keyword;

            var ldci4sInstruction = new NonTerminal("ldci4sInstruction");
            ldci4sInstruction.Rule = ldci4sKeyword + int8Value;

            var ldstrInstruction = new NonTerminal("ldstrInstruction");
            ldstrInstruction.Rule = ldstrKeyword + stringValue;

            var popInstruction = new NonTerminal("popInstruction");
            popInstruction.Rule = popKeyword;

            var retInstruction = new NonTerminal("retInstruction");
            retInstruction.Rule = retKeyword;

            var instruction = new NonTerminal("instruction");
            instruction.Rule =
                callInstruction |
                ldci40Instruction |
                ldci41Instruction |
                ldci42Instruction |
                ldci43Instruction |
                ldci44Instruction |
                ldci45Instruction |
                ldci46Instruction |
                ldci47Instruction |
                ldci48Instruction |
                ldci4m1Instruction |
                ldci4sInstruction |
                ldstrInstruction |
                popInstruction |
                retInstruction;

            var instructionsSequence = new NonTerminal("instructionsSequence");
            instructionsSequence.Rule = instruction | (instruction + instructionsSequence);

            // methods

            var methodParameters = new NonTerminal("methodParameters");
            methodParameters.Rule = leftParenthesis + rightParenthesis;

            var methodDeclBlock = new NonTerminal("methodDeclarationBlock");
            methodDeclBlock.Rule = leftBrace + entryPointKeyword + instructionsSequence + rightBrace;

            var methodDeclaration = new NonTerminal("methodDeclaration");
            methodDeclaration.Rule = methodDeclKeyword + (staticKeyword | Empty) + voidKeyword + identifier + methodParameters + cilKeyword + managedKeyword + methodDeclBlock;

            // classes

            var classDeclBlock = new NonTerminal("classDeclarationBlock");
            classDeclBlock.Rule = leftBrace + methodDeclaration + rightBrace;

            var classDeclaration = new NonTerminal("classDeclaration");
            classDeclaration.Rule = classDeclKeyword + namespaceIdentifier + classDeclBlock;

            // assemblies

            var assemblyDeclBlock = new NonTerminal("assemblyDeclarationBlock");
            assemblyDeclBlock.Rule = leftBrace + rightBrace;

            var assemblyDeclaration = new NonTerminal("assemblyDeclaration");
            assemblyDeclaration.Rule = assemblyDeclKeyword + optionalExternKeyword + identifier + assemblyDeclBlock;

            var assemblyDeclarations = new NonTerminal("assemblyDeclarations");
            assemblyDeclarations.Rule = assemblyDeclaration | (assemblyDeclaration + assemblyDeclarations);

            // program

            var program = new NonTerminal("program");
            program.Rule = assemblyDeclarations + classDeclaration;

            // root

            Root = program;
        }
    }
}
