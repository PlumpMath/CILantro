using System;

namespace CILantro.Shared.CILSimpleTypes
{
    public class CILInt32Type : CILSimpleType
    {
        public override Type ConvertToType()
        {
            return typeof(int);
        }
    }
}
