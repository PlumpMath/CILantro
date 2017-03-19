.assembly extern mscorlib {}

.assembly AddTwoNumbers {}

.class AddTwoNumbers.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		call string [mscorlib]System.Console::ReadLine()
		call int32 [mscorlib]System.Int32::Parse(string)
		
		call string [mscorlib]System.Console::ReadLine()
		call int32 [mscorlib]System.Int32::Parse(string)
		
		add
		
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}