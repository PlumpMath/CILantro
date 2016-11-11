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
                Interpret(reader, writer);
            });

            thread.Start();
            thread.Join();
        }

        private void Interpret(StreamReader reader, StreamWriter writer)
        {
            while (true)
            {
                writer.Write(CommandPrompt);
                writer.Flush();

                var line = reader.ReadLine();
                if(line == "exit")
                {
                    break;
                }
            }
        }
    }
}
