.assembly extern mscorlib {}

.assembly WriteM1 {}

.class WriteM1.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.M1
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}