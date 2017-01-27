using CILantro.Engine.AST;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTConstruction
{
    public class ProgramBuilder : CILASTNodeBuilder<CILProgram>
    {
        public override CILProgram BuildNode(ParseTreeNode node)
        {
            return new CILProgram();
        }
    }
}
