.assembly extern mscorlib {}

.assembly AddOverflow {}

.class AddOverflow.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.1
		ldc.i4.7
		add
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.5
		ldc.i4.8
		add
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.7
		add.ovf
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.5
		ldc.i4.8
		add.ovf
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.7
		add.ovf.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.5
		ldc.i4.8
		add.ovf.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}