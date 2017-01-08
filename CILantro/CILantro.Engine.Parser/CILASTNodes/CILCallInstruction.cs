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

        public override CILInstruction Execute(CILProgramRoot program)
        {
            var calledAssembly = program.Assemblies.First(a => a.Name.Equals(MethodAssemblyName));
            var reflectedAssembly = Assembly.Load(calledAssembly.Name);
            var reflectedClass = reflectedAssembly.GetType(MethodClassName);
            var reflectedMethod = reflectedClass.GetMethod(MethodName, new Type[0]);
            reflectedMethod.Invoke(null, null);

            return Method.GetNextInstruction(Order);
        }
    }
}
