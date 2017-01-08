using System;

namespace CILantro.Shared.CILSimpleTypes
{
    public class CILStringType : CILSimpleType
    {
        public override Type ConvertToType()
        {
            return typeof(string);
        }
    }
}
