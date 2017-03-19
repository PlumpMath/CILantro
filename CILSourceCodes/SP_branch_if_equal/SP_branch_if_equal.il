.assembly extern mscorlib {}

.assembly BranchIfEqual {}

.class BranchIfEqual.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.1
		ldc.i4.2
		beq 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		beq 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		beq.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		beq.s 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}