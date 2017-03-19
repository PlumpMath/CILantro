.assembly extern mscorlib {}

.assembly UnconditionalBranch {}

.class UnconditionalBranch.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		br 5
		br 5
		br -10
		br 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}