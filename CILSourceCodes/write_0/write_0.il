.assembly extern mscorlib {}

.assembly Write0 {}

.class Write0.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.0
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}