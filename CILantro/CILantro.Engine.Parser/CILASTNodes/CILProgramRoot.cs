using System.Collections.Generic;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILProgramRoot : CILASTNode
    {
        public List<CILAssembly> Assemblies { get; set; }

        public CILClass Class { get; set; }
    }
}
