.assembly extern mscorlib {}

.assembly Ns {}

.class Ns.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		neg
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		neg
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		neg
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.3
		neg
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.4
		neg
		call void [mscorlib]System.Console::WriteLine(int32)
		
		nop
		
		nop
		
		nop
		
		nop
		
		nop
		
		ldc.i4.0
		not
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		not
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		not
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.3
		not
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.4
		not
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}