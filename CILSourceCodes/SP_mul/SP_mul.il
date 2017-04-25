.assembly extern mscorlib {}

.assembly Mul {}

.class Mul.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.2
		ldc.i4.5
		mul
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.4
		ldc.i4.7
		mul
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.5
		mul.ovf
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.4
		ldc.i4.7
		mul.ovf
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.5
		mul.ovf.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.4
		ldc.i4.7
		mul.ovf.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}