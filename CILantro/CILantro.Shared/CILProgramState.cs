using System.Collections.Generic;

namespace CILantro.Shared
{
    public class CILProgramState
    {
        public Stack<object> Stack { get; set; }

        public CILProgramState()
        {
            Stack = new Stack<object>();
        }
    }
}
