.assembly extern mscorlib {}

.assembly Cgt {}

.class Cgt.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		ldc.i4.0
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.1
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.2
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.0
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.1
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.2
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.0
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.1
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.2
		cgt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}