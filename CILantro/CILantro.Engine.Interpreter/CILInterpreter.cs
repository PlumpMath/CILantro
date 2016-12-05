using CILantro.Engine.Parser;
using CILantro.Engine.Parser.CILASTNodes;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace CILantro.Engine.Interpreter
{
    public class CILInterpreter
    {
        //private static readonly string CommandPrompt = "CILantro >>> ";

        private CILProgramRoot Program { get; set; }

        private StreamReader StreamReader { get; set; }

        private StreamWriter StreamWriter { get; set; }

        public void StartInterpreter(CILProgram cilProgram, StreamReader reader, StreamWriter writer)
        {
            Program = cilProgram.Root;
            StreamReader = reader;
            StreamWriter = writer;

            var thread = new Thread(() =>
            {
                Interpret();
            });

            thread.Start();
            thread.Join();
        }

        private void Interpret()
        {
            Console.SetIn(StreamReader);
            Console.SetOut(StreamWriter);
            StreamWriter.AutoFlush = true;

            var entryPoint = Program.Class.Method;
            InvokeMethod(entryPoint);
        }

        private void InvokeMethod(CILMethod method)
        {
            foreach(var instruction in method.Instructions)
            {
                InvokeInstruction(instruction);
            }
        }

        private void InvokeInstruction(CILInstruction instruction)
        {
            if (instruction is CILCallInstruction)
                InvokeCallInstruction(instruction as CILCallInstruction);
            else if (instruction is CILPopInstruction)
                InvokePopInstruction(instruction as CILPopInstruction);
            else if (instruction is CILRetInstruction)
                InvokeRetInstruction(instruction as CILRetInstruction);            
        }

        private void InvokeCallInstruction(CILCallInstruction callInstruction)
        {
            var calledAssembly = Program.Assemblies.First(a => a.Name.Equals(callInstruction.MethodAssemblyName));
            var reflectedAssembly = Assembly.Load(calledAssembly.Name);
            var reflectedClass = reflectedAssembly.GetType(callInstruction.MethodClassName);
            var reflectedMethod = reflectedClass.GetMethod(callInstruction.MethodName, new Type[0]);
            reflectedMethod.Invoke(null, null);
        }

        private void InvokePopInstruction(CILPopInstruction popInstruction)
        {

        }

        private void InvokeRetInstruction(CILRetInstruction retInstruction)
        {

        }
    }
}
