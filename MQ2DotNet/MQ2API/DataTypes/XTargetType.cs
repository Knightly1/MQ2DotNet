﻿// ReSharper disable UnusedMember.Global

namespace MQ2DotNet.MQ2API.DataTypes
{
    public class XTargetType : SpawnType
    {
        internal XTargetType(MQ2TypeVar typeVar) : base(typeVar)
        {
        }

        /// <summary>
        /// Memory address of XTargetMgr
        /// </summary>
        public new IntType Address => GetMember<IntType>("Address");

        /// <summary>
        /// Extended target type e.g. Auto Hater
        /// </summary>
        public string TargetType => GetMember<StringType>("TargetType");

        /// <summary>
        /// Spawn ID
        /// </summary>
        public new IntType ID => GetMember<IntType>("ID");

        /// <summary>
        /// Spawn's name
        /// </summary>
        public new string Name => GetMember<StringType>("Name");

        /// <summary>
        /// Your percentage aggro on the spawn
        /// </summary>
        public IntType PctAggro => GetMember<IntType>("PctAggro");
    }
}