.assembly extern mscorlib {}

.assembly UnconditionalBranch {}

.class UnconditionalBranch.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		br.s 2
		br.s 2
		br.s -4
		br.s 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}