using CILantro.Engine.AST;

namespace CILantro.Engine.Parser
{
    public class CILParser
    {
        private readonly Irony.Parsing.Parser _parser = new Irony.Parsing.Parser(new CILGrammar());

        public CILProgram Parse(string sourceCode)
        {
            var parseTree = _parser.Parse(sourceCode);
            if (parseTree.Status == Irony.Parsing.ParseTreeStatus.Parsed)
            {
                #region too doo

                //var result = _astBuilder.BuildTree(parseTree);
                //return result;
                return new CILProgram();

                #endregion
            }

            #region too doo

            //var error = parseTree.ParserMessages.First();
            //var errorMessage = BuildErrorMessage(error);
            //throw new ArgumentException(errorMessage);
            throw new System.Exception();

            #endregion
        }

        #region too doo

        //private string BuildErrorMessage(LogMessage logMessage)
        //{
        //    return $"Cannot parse the source code:\n{logMessage.Location}: {logMessage.Message}.";
        //}

        #endregion
    }
}
