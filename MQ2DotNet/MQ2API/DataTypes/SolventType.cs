﻿// ReSharper disable UnusedMember.Global

namespace MQ2DotNet.MQ2API.DataTypes
{
    public class SolventType : MQ2DataType
    {
        /// <summary>
        /// Item name
        /// </summary>
        public StringType Name => GetMember<StringType>("Name");

        /// <summary>
        /// Item ID
        /// </summary>
        public IntType ID => GetMember<IntType>("ID");

        /// <summary>
        /// <see cref="ItemType"/> for the solvent, if available
        /// </summary>
        public ItemType Item => GetMember<ItemType>("Item");

        /// <summary>
        /// How many we currently have in inventory
        /// </summary>
        public IntType Count => GetMember<IntType>("Count");
    }
}