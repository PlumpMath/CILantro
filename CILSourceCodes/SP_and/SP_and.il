.assembly extern mscorlib {}

.assembly And {}

.class And.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.1
		ldc.i4.0
		and
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.1
		and
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.2
		and
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}