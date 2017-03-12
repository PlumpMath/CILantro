using System.Collections.Generic;
using System.Reflection;

namespace CILantro.Engine.AST.ASTNodes.Instructions
{
    public class CallInstruction : InstructionMethod
    {
        public override CILInstruction Execute(CILProgram program, CILProgramState state)
        {
            var reflectedAssembly = Assembly.Load(AssemblyName);
            var reflectedClass = reflectedAssembly.GetType(ClassName);
            var reflectedMethod = reflectedClass.GetMethod(MethodName, ArgumentsTypes);

            var argumentsList = new List<object>();
            for(int i = 0; i < ArgumentsTypes.Length; i++)
            {
                var argument = state.Stack.Pop();
                argumentsList.Add(argument);
            }

            reflectedMethod.Invoke(null, argumentsList.ToArray());

            return Method.GetNextInstruction(this);
        }
    }
}
