.assembly extern mscorlib {}

.assembly Write5 {}

.class Write5.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.5
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}