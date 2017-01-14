.assembly extern mscorlib {}

.assembly WriteSomeNumbersInt32 {}

.class WriteSomeNumbersInt32.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4 0
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 10
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 100
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 1000
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 10000
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 100000
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 1000000
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 -10
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 -100
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 -1000
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 -10000
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 -100000
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 -1000000
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}