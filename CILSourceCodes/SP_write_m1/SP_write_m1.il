.assembly extern mscorlib {}

.assembly WriteM1 {}

.class WriteM1.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldc.i4.m1
		call void [mscorlib]System.Console::WriteLine(int32)
		ret
	}
}