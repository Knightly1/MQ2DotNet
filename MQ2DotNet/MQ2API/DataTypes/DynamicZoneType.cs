﻿namespace MQ2DotNet.MQ2API.DataTypes
{
    public class DynamicZoneType : MQ2DataType
    {
        public DynamicZoneType()
        {
            xMember = new IndexedMember<DZMemberType, int, DZMemberType, string>(this, "xMember");
        }

        /// <summary>
        /// The full name of the dynamic zone
        /// </summary>
        public StringType Name => GetMember<StringType>("Name");

        /// <summary>
        /// Current number of characters in the dynamic zone
        /// </summary>
        public IntType Members => GetMember<IntType>("Members");

        /// <summary>
        /// Maximum number of characters that can enter this dynamic zone
        /// </summary>
        public IntType MaxMembers => GetMember<IntType>("MaxMembers");

        /// <summary>
        /// Member of the dynamic zone by name or number
        /// </summary>
        public IndexedMember<DZMemberType, int, DZMemberType, string> xMember { get; }

        /// <summary>
        /// The leader of the dynamic zone
        /// </summary>
        public DZMemberType Leader => GetMember<DZMemberType>("Leader");
        
        /// <summary>
        /// TODO: Document DynamicZoneType.InRaid
        /// </summary>
        public BoolType InRaid => GetMember<BoolType>("InRaid");
    }
}