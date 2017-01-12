.assembly extern mscorlib {}

.assembly Write3 {}

.class Write3.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.3
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}