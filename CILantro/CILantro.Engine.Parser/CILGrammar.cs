using Irony.Parsing;

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

            var addToken = ToTerm("add", GrammarNames.AddToken);
            var addovfToken = ToTerm("add.ovf", GrammarNames.AddovfToken);
            var addovfunToken = ToTerm("add.ovf.un", GrammarNames.AddovfunToken);
            var andToken = ToTerm("and", GrammarNames.AndToken);
            var beqToken = ToTerm("beq", GrammarNames.BeqToken);
            var beqsToken = ToTerm("beq.s", GrammarNames.BeqsToken);
            var bgeToken = ToTerm("bge", GrammarNames.BgeToken);
            var bgesToken = ToTerm("bge.s", GrammarNames.BgesToken);
            var bgeunToken = ToTerm("bge.un", GrammarNames.BgeunToken);
            var bgeunsToken = ToTerm("bge.un.s", GrammarNames.BgeunsToken);
            var bgtToken = ToTerm("bgt", GrammarNames.BgtToken);
            var bgtsToken = ToTerm("bgt.s", GrammarNames.BgtsToken);
            var bgtunToken = ToTerm("bgt.un", GrammarNames.BgtunToken);
            var bgtunsToken = ToTerm("bgt.un.s", GrammarNames.BgtunsToken);
            var bleToken = ToTerm("ble", GrammarNames.BleToken);
            var blesToken = ToTerm("ble.s", GrammarNames.BlesToken);
            var bleunToken = ToTerm("ble.un", GrammarNames.BleunToken);
            var bleunsToken = ToTerm("ble.un.s", GrammarNames.BleunsToken);
            var bltToken = ToTerm("blt", GrammarNames.BltToken);
            var bltsToken = ToTerm("blt.s", GrammarNames.BltsToken);
            var bltunToken = ToTerm("blt.un", GrammarNames.BltunToken);
            var bltunsToken = ToTerm("blt.un.s", GrammarNames.BltunsToken);
            var bneunToken = ToTerm("bne.un", GrammarNames.BneunToken);
            var bneunsToken = ToTerm("bne.un.s", GrammarNames.BneunsToken);
            var brToken = ToTerm("br", GrammarNames.BrToken);
            var brsToken = ToTerm("br.s", GrammarNames.BrsToken);
            var brfalseToken = ToTerm("brfalse", GrammarNames.BrfalseToken);
            var brfalsesToken = ToTerm("brfalse.s", GrammarNames.BrfalsesToken);
            var brtrueToken = ToTerm("brtrue", GrammarNames.BrtrueToken);
            var brtruesToken = ToTerm("brtrue.s", GrammarNames.BrtruesToken);
            var callToken = ToTerm("call", GrammarNames.CallToken);
            var ceqToken = ToTerm("ceq", GrammarNames.CeqToken);
            var cgtToken = ToTerm("cgt", GrammarNames.CgtToken);
            var cgtunToken = ToTerm("cgt.un", GrammarNames.CgtunToken);
            var cilToken = ToTerm("cil", GrammarNames.CilToken);
            var cltToken = ToTerm("clt", GrammarNames.CltToken);
            var cltunToken = ToTerm("clt.un", GrammarNames.CltunToken);
            var divToken = ToTerm("div", GrammarNames.DivToken);
            var divunToken = ToTerm("div.un", GrammarNames.DivunToken);
            var dotAssemblyToken = ToTerm(".assembly", GrammarNames.DotAssemblyToken);
            var dotClassToken = ToTerm(".class", GrammarNames.DotClassToken);
            var dotEntrypointToken = ToTerm(".entrypoint", GrammarNames.DotEntrypointToken);
            var dotMethodToken = ToTerm(".method", GrammarNames.DotMethodToken);
            var dupToken = ToTerm("dup", GrammarNames.DupToken);
            var externToken = ToTerm("extern", GrammarNames.ExternToken);
            var int32Token = ToTerm("int32", GrammarNames.Int32Token);
            var ldci4Token = ToTerm("ldc.i4", GrammarNames.Ldci4Token);
            var ldci40Token = ToTerm("ldc.i4.0", GrammarNames.Ldci40Token);
            var ldci41Token = ToTerm("ldc.i4.1", GrammarNames.Ldci41Token);
            var ldci42Token = ToTerm("ldc.i4.2", GrammarNames.Ldci42Token);
            var ldci43Token = ToTerm("ldc.i4.3", GrammarNames.Ldci43Token);
            var ldci44Token = ToTerm("ldc.i4.4", GrammarNames.Ldci44Token);
            var ldci45Token = ToTerm("ldc.i4.5", GrammarNames.Ldci45Token);
            var ldci46Token = ToTerm("ldc.i4.6", GrammarNames.Ldci46Token);
            var ldci47Token = ToTerm("ldc.i4.7", GrammarNames.Ldci47Token);
            var ldci48Token = ToTerm("ldc.i4.8", GrammarNames.Ldci48Token);
            var ldci4m1Token = ToTerm("ldc.i4.m1", GrammarNames.Ldci4m1Token);
            var ldci4M1Token = ToTerm("ldc.i4.M1", GrammarNames.Ldci4m1AliasToken);
            var ldci4sToken = ToTerm("ldc.i4.s", GrammarNames.Ldci4sToken);
            var ldstrToken = ToTerm("ldstr", GrammarNames.LdstrToken);
            var leaveToken = ToTerm("leave", GrammarNames.LeaveToken);
            var leavesToken = ToTerm("leave.s", GrammarNames.LeavesToken);
            var managedToken = ToTerm("managed", GrammarNames.ManagedToken);
            var mulToken = ToTerm("mul", GrammarNames.MulToken);
            var mulovfToken = ToTerm("mul.ovf", GrammarNames.MulovfToken);
            var mulovfunToken = ToTerm("mul.ovf.un", GrammarNames.MulovfunToken);
            var negToken = ToTerm("neg", GrammarNames.NegToken);
            var nopToken = ToTerm("nop", GrammarNames.NopToken);
            var notToken = ToTerm("not", GrammarNames.NotToken);
            var orToken = ToTerm("or", GrammarNames.OrToken);
            var popToken = ToTerm("pop", GrammarNames.PopToken);
            var retToken = ToTerm("ret", GrammarNames.RetToken);
            var shlToken = ToTerm("shl", GrammarNames.ShlToken);
            var shrToken = ToTerm("shr", GrammarNames.ShrToken);
            var staticToken = ToTerm("static", GrammarNames.StaticToken);
            var stringToken = ToTerm("string", GrammarNames.StringToken);
            var subToken = ToTerm("sub", GrammarNames.SubToken);
            var subovfToken = ToTerm("sub.ovf", GrammarNames.SubovfToken);
            var subovfunToken = ToTerm("sub.ovf.un", GrammarNames.SubovfunToken);
            var valuetypeToken = ToTerm("valuetype", GrammarNames.ValuetypeToken);
            var voidToken = ToTerm("void", GrammarNames.VoidToken);
            var xorToken = ToTerm("xor", GrammarNames.XorToken);

            // lexical tokens

            var identifier = new IdentifierTerminal(GrammarNames.Identifier);

            var quotedString = new StringLiteral(GrammarNames.QuotedString, "\"");

            var integer = new NumberLiteral(GrammarNames.Integer, NumberOptions.IntOnly | NumberOptions.AllowSign);

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
                addToken |
                addovfToken |
                addovfunToken |
                andToken |
                ceqToken |
                cgtToken |
                cgtunToken |
                cltToken |
                cltunToken |
                divToken |
                divunToken |
                dupToken |
                ldci40Token |
                ldci41Token |
                ldci42Token |
                ldci43Token |
                ldci44Token |
                ldci45Token |
                ldci46Token |
                ldci47Token |
                ldci48Token |
                ldci4m1Token |
                ldci4M1Token |
                mulToken |
                mulovfToken |
                mulovfunToken |
                negToken |
                nopToken |
                notToken |
                orToken |
                popToken |
                retToken |
                shlToken |
                shrToken |
                subToken |
                subovfToken |
                subovfunToken |
                xorToken;

            var instructionBranch = new NonTerminal(GrammarNames.InstructionBranch);
            instructionBranch.Rule =
                beqToken |
                beqsToken |
                bgeToken |
                bgesToken |
                bgeunToken |
                bgeunsToken |
                bgtToken |
                bgtsToken |
                bgtunToken |
                bgtunsToken |
                bleToken |
                blesToken |
                bleunToken |
                bleunsToken |
                bltToken |
                bltsToken |
                bltunToken |
                bltunsToken |
                bneunToken |
                bneunsToken |
                brToken |
                brsToken |
                brfalseToken |
                brfalsesToken |
                brtrueToken |
                brtruesToken |
                leaveToken |
                leavesToken;

            var instructionInt = new NonTerminal(GrammarNames.InstructionInt);
            instructionInt.Rule =
                ldci4Token |
                ldci4sToken;

            var instructionMethod = new NonTerminal(GrammarNames.InstructionMethod);
            instructionMethod.Rule = callToken;

            var instructionString = new NonTerminal(GrammarNames.InstructionString);
            instructionString.Rule = ldstrToken;

            var instruction = new NonTerminal(GrammarNames.Instruction);
            instruction.Rule =
                instructionBranch + integer |
                instructionInt + integer |
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
