﻿using JetBrains.Annotations;

namespace MQ2DotNet.MQ2API.DataTypes
{
    /// <summary>
    /// MQ2 type for a boolean
    /// </summary>
    [PublicAPI]
    [MQ2Type("bool")]
    public class BoolType : MQ2DataType
    {
        internal BoolType(MQ2TypeVar typeVar) : base(typeVar)
        {
        }

        /// <summary>
        /// Implicit conversion to a bool
        /// </summary>
        /// <param name="typeVar"></param>
        public static implicit operator bool(BoolType typeVar)
        {
            return typeVar.VarPtr.Dword != 0;
        }
    }
}