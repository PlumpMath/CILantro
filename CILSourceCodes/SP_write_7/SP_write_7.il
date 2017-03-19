.assembly extern mscorlib {}

.assembly Write7 {}

.class Write7.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.7
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}