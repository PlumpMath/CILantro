.assembly extern mscorlib {}

.assembly WriteSomeNumbersInt32 {}

.class WriteSomeNumbersInt32.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.s 0
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 1
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 2
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 3
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 4
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 5
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 6
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 7
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 8
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 9
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s 10
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -1
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -2
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -3
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -4
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -5
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -6
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -7
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -8
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -9
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.s -10
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}