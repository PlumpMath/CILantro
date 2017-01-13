.assembly extern mscorlib {}

.assembly Write8 {}

.class Write8.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.8
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}