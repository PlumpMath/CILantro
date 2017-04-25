.assembly extern mscorlib {}

.assembly Sub {}

.class Sub.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.5
		ldc.i4.2
		sub
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.8
		ldc.i4.6
		sub
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.5
		ldc.i4.2
		sub.ovf
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.8
		ldc.i4.6
		sub.ovf
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.5
		ldc.i4.2
		sub.ovf.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.8
		ldc.i4.6
		sub.ovf.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}