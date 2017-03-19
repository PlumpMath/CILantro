.assembly extern mscorlib {}

.assembly AddSomeNumbers {}

.class AddSomeNumbers.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4 2
		ldc.i4 3
		add
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 17
		ldc.i4 -2
		add
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4 99
		ldc.i4 1
		add
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}