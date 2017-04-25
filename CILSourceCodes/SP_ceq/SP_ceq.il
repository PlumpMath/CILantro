.assembly extern mscorlib {}

.assembly Ceq {}

.class Ceq.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		ldc.i4.0
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.1
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.2
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.0
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.1
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.2
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.0
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.1
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.2
		ceq
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}