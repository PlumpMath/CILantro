.assembly extern mscorlib {}

.assembly BranchIfGreaterOrEqual {}

.class BranchIfGreaterOrEqual.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.2
		ldc.i4.1
		bge 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		bge 10
		
		ldstr "This text shouldnt' be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		bge 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.2
		ldc.i4.1
		bge.s 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		bge.s 10
		
		ldstr "This text shouldnt' be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		bge.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.2
		ldc.i4.1
		bge.un 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		bge.un 10
		
		ldstr "This text shouldnt' be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		bge.un 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.2
		ldc.i4.1
		bge.un.s 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.1
		bge.un.s 10
		
		ldstr "This text shouldnt' be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldc.i4.1
		ldc.i4.2
		bge.un.s 10
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}