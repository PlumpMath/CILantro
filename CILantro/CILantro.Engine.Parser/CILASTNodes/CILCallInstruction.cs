using CILantro.Shared;
using CILantro.Shared.CILSimpleTypes;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILCallInstruction : CILInstruction
    {
        public string MethodAssemblyName { get; set; }

        public string MethodClassName { get; set; }

        public string MethodName { get; set; }

        public List<CILSimpleType> ArgumentTypes { get; set; }

        public override CILInstruction Execute(CILProgramRoot program, CILProgramState state)
        {
            var calledAssembly = program.Assemblies.First(a => a.Name.Equals(MethodAssemblyName));
            var reflectedAssembly = Assembly.Load(calledAssembly.Name);
            var reflectedClass = reflectedAssembly.GetType(MethodClassName);
            var reflectedMethodArgumentTypes = ArgumentTypes.Select(at => at.ConvertToType()).ToArray();
            var reflectedMethod = reflectedClass.GetMethod(MethodName, reflectedMethodArgumentTypes);

            var arguments = new object[ArgumentTypes.Count];
            for(int i = 0; i < ArgumentTypes.Count; i++)
            {
                arguments[i] = state.Stack.Pop();
            }

            reflectedMethod.Invoke(null, arguments);

            return Method.GetNextInstruction(Order);
        }
    }
}
