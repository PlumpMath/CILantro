.assembly extern mscorlib {}

.assembly Write4 {}

.class Write4.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.4
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}