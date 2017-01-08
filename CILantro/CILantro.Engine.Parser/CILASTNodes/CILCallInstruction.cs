using CILantro.Shared;
using System;
using System.Linq;
using System.Reflection;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILCallInstruction : CILInstruction
    {
        public string MethodAssemblyName { get; set; }

        public string MethodClassName { get; set; }

        public string MethodName { get; set; }

        public int ArgumentsCount { get; set; }

        public override CILInstruction Execute(CILProgramRoot program, CILProgramState state)
        {
            var calledAssembly = program.Assemblies.First(a => a.Name.Equals(MethodAssemblyName));
            var reflectedAssembly = Assembly.Load(calledAssembly.Name);
            var reflectedClass = reflectedAssembly.GetType(MethodClassName);
            var reflectedMethodArgumentTypes = Enumerable.Repeat(typeof(string), ArgumentsCount).ToArray();
            var reflectedMethod = reflectedClass.GetMethod(MethodName, reflectedMethodArgumentTypes);

            var arguments = new object[ArgumentsCount];
            for(int i = 0; i < ArgumentsCount; i++)
            {
                arguments[i] = state.Stack.Pop();
            }

            reflectedMethod.Invoke(null, arguments);

            return Method.GetNextInstruction(Order);
        }
    }
}
