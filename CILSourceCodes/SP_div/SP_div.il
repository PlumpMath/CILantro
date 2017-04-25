.assembly extern mscorlib {}

.assembly Div {}

.class Div.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		ldc.i4.5
		div
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.3
		ldc.i4.2
		div
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.8
		ldc.i4.4
		div
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.5
		div.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.3
		ldc.i4.2
		div.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.8
		ldc.i4.4
		div.un
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}