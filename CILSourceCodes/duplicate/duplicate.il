.assembly extern mscorlib {}

.assembly Duplicate {}

.class Duplicate.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		call string [mscorlib]System.Console::ReadLine()
		call int32[mscorlib]System.Int32::Parse(string)
		
		dup
		
		call void[mscorlib]System.Console::WriteLine(int32)
		call void[mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}