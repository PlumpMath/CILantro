.assembly extern mscorlib {}

.assembly Or {}

.class Or.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		ldc.i4.0
		or
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.1
		or
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.2
		or
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.2
		or
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.3
		or
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.0
		xor
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.1
		xor
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.2
		xor
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.2
		xor
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.3
		xor
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}