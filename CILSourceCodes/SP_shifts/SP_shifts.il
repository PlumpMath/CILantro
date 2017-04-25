.assembly extern mscorlib {}

.assembly Shifts {}

.class Shifts.Program
{
	.method static void Main() cil managed
	{
		.entrypoint
		
		ldc.i4.0
		ldc.i4.0
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.1
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.2
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.3
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.0
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.1
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.2
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.3
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.0
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.1
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.2
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.3
		shl
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.0
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.1
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.2
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.0
		ldc.i4.3
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.0
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.1
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.2
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.1
		ldc.i4.3
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.0
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.1
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.2
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ldc.i4.2
		ldc.i4.3
		shr
		call void [mscorlib]System.Console::WriteLine(int32)
		
		ret
	}
}