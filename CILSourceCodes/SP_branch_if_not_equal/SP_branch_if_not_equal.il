.assembly extern mscorlib {}

.assembly BranchIfNotEqual {}

.class BranchIfNotEqual.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.2
		ldc.i4.1
		bne.un 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		bne.un 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		bne.un 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.2
		ldc.i4.1
		bne.un.s 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		bne.un.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		bne.un.s 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}