using System;
using System.Reflection;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class CallInstruction : InstructionMethod
    {
        public override CILInstruction Execute(CILProgram program)
        {
            var reflectedAssembly = Assembly.Load(AssemblyName);
            var reflectedClass = reflectedAssembly.GetType(ClassName);
            var reflectedMethod = reflectedClass.GetMethod(MethodName, new Type[0]);

            reflectedMethod.Invoke(null, null);

            return Method.GetNextInstruction(this);
        }
    }
}
