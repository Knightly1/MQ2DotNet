﻿// ReSharper disable UnusedMember.Global

namespace MQ2DotNet.MQ2API.DataTypes
{
    public class GroupType : MQ2DataType
    {
        public GroupType()
        {
            Injured = new IndexedMember<IntType, int>(this, "Injured");
            Member = new IndexedMember<GroupMemberType, string, GroupMemberType, int>(this, "Member");
        }

        /// <summary>
        /// Memory address of the GROUPINFO struct
        /// </summary>
        public IntType Address => GetMember<IntType>("Address");
        
        /// <summary>
        /// A group member by name or number (0 - 5)
        /// </summary>
        public IndexedMember<GroupMemberType, string, GroupMemberType, int> Member { get; }

        /// <summary>
        /// Total number of group members, excluding yourself
        /// </summary>
        public IntType Members => GetMember<IntType>("Members");

        /// <summary>
        /// Data on the leader of the group
        /// </summary>
        public GroupMemberType Leader => GetMember<GroupMemberType>("Leader");

        /// <summary>
        /// Number of members in your group, including yourself
        /// </summary>
        public IntType GroupSize => GetMember<IntType>("GroupSize");

        /// <summary>
        /// Data on the main tank of the group
        /// </summary>
        public GroupMemberType MainTank => GetMember<GroupMemberType>("MainTank");

        /// <summary>
        /// Data on the main assist of the group
        /// </summary>
        public GroupMemberType MainAssist => GetMember<GroupMemberType>("MainAssist");

        /// <summary>
        /// Data on the puller of the group
        /// </summary>
        public GroupMemberType Puller => GetMember<GroupMemberType>("Puller");

        /// <summary>
        /// Data on the mark NPCs role of the group
        /// </summary>
        public GroupMemberType MarkNpc => GetMember<GroupMemberType>("MarkNpc");

        /// <summary>
        /// Data on the master looter of the group
        /// </summary>
        public GroupMemberType MasterLooter => GetMember<GroupMemberType>("MasterLooter");

        /// <summary>
        /// TRUE if someone is missing in group, offline, in other zone or simply just dead
        /// </summary>
        public BoolType AnyoneMissing => GetMember<BoolType>("AnyoneMissing");

        /// <summary>
        /// Number of group members (excluding yourself) that are in zone and alive
        /// </summary>
        public IntType Present => GetMember<IntType>("Present");

        /// <summary>
        /// Count of how many mercenaries are in your group
        /// </summary>
        public IntType MercenaryCount => GetMember<IntType>("MercenaryCount");

        /// <summary>
        /// Count of how many Tank mercenaries are in your group
        /// </summary>
        public IntType TankMercCount => GetMember<IntType>("TankMercCount");

        /// <summary>
        /// Count of how many Healer mercenaries are in your group
        /// </summary>
        public IntType HealerMercCount => GetMember<IntType>("HealerMercCount");

        /// <summary>
        /// Count of how many Melee DPS mercenaries are in your group
        /// </summary>
        public IntType MeleeMercCount => GetMember<IntType>("MeleeMercCount");

        /// <summary>
        /// Count of how many Caster DPS mercenaries are in your group
        /// </summary>
        public IntType CasterMercCount => GetMember<IntType>("CasterMercCount");
        
        /// <summary>
        /// Average HP percentage of group members, including yourself
        /// </summary>
        public IntType AvgHPs => GetMember<IntType>("AvgHPs");

        /// <summary>
        /// Will return the numbers of people in the group that has less than a certain percentage HP
        /// </summary>
        public IndexedMember<IntType, int> Injured;

        /// <summary>
        /// The first non-mercenary cleric in the group
        /// </summary>
        public SpawnType XCleric => GetMember<SpawnType>("XCleric");

        /// <summary>
        /// Group member the mouse is currently over
        /// </summary>
        public GroupMemberType MouseOver => GetMember<GroupMemberType>("MouseOver");
    }
}