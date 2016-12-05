.assembly extern mscorlib {}

.assembly HelloWorld {}

.class HelloWorld.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
		pop
		ret
	}
}