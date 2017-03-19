.assembly extern mscorlib {}

.assembly BranchIfFalse {}

.class BranchIfFalse.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		brfalse 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		brfalse 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}