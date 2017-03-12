using CILantro.Engine.AST;
using System;
using System.IO;
using System.Linq;

namespace CILantro.Engine.Interpreter
{
    public class CILInterpreter
    {
        private CILProgram Program { get; set; }

        private CILProgramState State { get; set; }

        private StreamReader StreamReader { get; set; }

        private StreamWriter StreamWriter { get; set; }

        public void StartInterpreter(CILProgram cilProgram, StreamReader reader, StreamWriter writer)
        {
            State = new CILProgramState();
            Program = cilProgram;
            StreamReader = reader;
            StreamWriter = writer;
            Interpret();
        }

        private void Interpret()
        {
            Console.SetIn(StreamReader);
            Console.SetOut(StreamWriter);
            StreamWriter.AutoFlush = true;

            var entryPoint = Program.Class.Method;
            var currentInstruction = entryPoint.Instructions.First();

            while (currentInstruction != null)
            {
                currentInstruction = currentInstruction.Execute(Program, State);
            }
        }
    }
}
