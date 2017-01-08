using CILantro.Shared.CILSimpleTypes;
using Irony.Parsing;
using System.Linq;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILSimpleTypeBuilder
    {
        public CILSimpleType BuildSimpleType(ParseTreeNode parseNode)
        {
            var int32TypeIdentifierParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsInt32TypeIdentifierNode());
            if (int32TypeIdentifierParseNode != null) return new CILInt32Type();

            var stringTypeIdentifierParseNode = parseNode.ChildNodes.FirstOrDefault(cn => cn.IsStringTypeIdentifierNode());
            if (stringTypeIdentifierParseNode != null) return new CILStringType();

            return null;
        }
    }
}
