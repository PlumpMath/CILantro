.assembly extern mscorlib {}

.assembly Write1 {}

.class Write1.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.1
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}