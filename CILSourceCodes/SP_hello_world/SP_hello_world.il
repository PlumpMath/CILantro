.assembly extern mscorlib {}

.assembly HelloWorld {}

.class HelloWorld.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		ldstr "Hello world!"
		call void [mscorlib]System.Console::WriteLine(string)
		ret
	}
}