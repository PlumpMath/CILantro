.assembly extern mscorlib {}

.assembly BranchIfLess {}

.class BranchIfLess.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.2
		ldc.i4.1
		blt 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		blt 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		blt 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.2
		ldc.i4.1
		blt.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		blt.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		blt.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.2
		ldc.i4.1
		blt.un 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		blt.un 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		blt.un 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.2
		ldc.i4.1
		blt.un.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		blt.un.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		blt.un.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}