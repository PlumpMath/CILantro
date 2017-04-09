.assembly extern mscorlib {}

.assembly Leave {}

.class Leave.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		leave 5
		leave 5
		leave -10
		leave 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		leave.s 2
		leave.s 2
		leave.s -4
		leave.s 10
		
		ldstr "This text shouldn't be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ldstr "This text should be written out."
		call void [mscorlib]System.Console::WriteLine(string)
		
		ret
	}
}