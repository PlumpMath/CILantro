.assembly extern mscorlib {}

.assembly Clt {}

.class Clt.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		ldc.i4.0
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.1
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.2
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.0
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.1
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.2
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.0
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.1
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.2
		clt
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}