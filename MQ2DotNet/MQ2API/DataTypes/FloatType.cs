﻿namespace MQ2DotNet.MQ2API.DataTypes
{
    public class FloatType : MQ2DataType
    {
        public static implicit operator float(FloatType typeVar)
        {
            return typeVar.VarPtr.Float;
        }
    }
}