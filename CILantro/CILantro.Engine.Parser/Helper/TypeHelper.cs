using System;

namespace CILantro.Engine.Parser.Helper
{
    public static class TypeHelper
    {
        public static Type GetTypeByName(string typeName)
        {
            switch(typeName)
            {
                case "string":
                    return typeof(string);
                default:
                    throw new ArgumentException("Cannot recognize type name.");
            }
        }
    }
}
