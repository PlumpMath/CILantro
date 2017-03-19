.assembly extern mscorlib {}

.assembly Write2 {}

.class Write2.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.2
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}