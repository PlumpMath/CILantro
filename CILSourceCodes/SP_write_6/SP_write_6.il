.assembly extern mscorlib {}

.assembly Write6 {}

.class Write6.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.6
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}