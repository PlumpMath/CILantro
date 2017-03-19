.assembly extern mscorlib {}

.assembly BranchIfTrueShort {}

.class BranchIfTrueShort.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		brtrue.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		brtrue.s 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}