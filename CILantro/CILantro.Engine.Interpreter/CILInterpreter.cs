using CILantro.Engine.Parser;
using System.IO;
using System.Threading;

namespace CILantro.Engine.Interpreter
{
    public class CILInterpreter
    {
        private static readonly string CommandPrompt = "CILantro >>> ";

        public void StartInterpreter(CILProgram cilProgram, StreamReader reader, StreamWriter writer)
        {
            var thread = new Thread(() =>
            {
                Interpret(cilProgram, reader, writer);
            });

            thread.Start();
            thread.Join();
        }

        private void Interpret(CILProgram cilProgram, StreamReader reader, StreamWriter writer)
        {
            writer.WriteLine(CommandPrompt);
            writer.Flush();

            var entryPoint = cilProgram.Root.Class.Method;
            entryPoint.Invoke();
        }
    }
}
