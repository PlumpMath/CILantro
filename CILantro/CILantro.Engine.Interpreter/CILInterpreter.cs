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
            Interpret();
        }

        private void Interpret()
        {
            Console.SetIn(StreamReader);
            Console.SetOut(StreamWriter);
            StreamWriter.AutoFlush = true;

            var entryPoint = Program.Class.Method;
            entryPoint.Invoke(Program);
        }
    }
}
