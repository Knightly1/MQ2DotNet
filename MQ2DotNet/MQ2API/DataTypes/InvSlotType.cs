﻿// ReSharper disable UnusedMember.Global

namespace MQ2DotNet.MQ2API.DataTypes
{
    // item slots:
    // 2000-2015 bank window
    // 2500-2503 shared bank
    // 5000-5031 loot window
    // 3000-3015 trade window (including npc) 3000-3007 are your slots, 3008-3015 are other character's slots
    // 4000-4010 world container window
    // 6000-6080 merchant window
    // 7000-7080 bazaar window
    // 8000-8031 inspect window

    public class InvSlotType : MQ2DataType
    {
        internal InvSlotType(MQ2TypeVar typeVar) : base(typeVar)
        {
        }

        /// <summary>
        /// ID of this item slot (usable directly by /itemnotify)
        /// </summary>
        public IntType ID => GetMember<IntType>("ID");

        /// <summary>
        /// Item data for the item in this slot
        /// </summary>
        public ItemType Item => GetMember<ItemType>("Item");

        /// <summary>
        /// Container that must be opened to access the slot with /itemnotify
        /// </summary>
        public InvSlotType Pack => GetMember<InvSlotType>("Pack");

        /// <summary>
        /// Slot number inside the pack which holds the item, otherwise NULL
        /// </summary>
        public IntType Slot => GetMember<IntType>("Slot");

        /// <summary>
        /// For inventory slots not inside packs, the slot name, otherwise NULL
        /// </summary>
        public string Name => GetMember<StringType>("Name");
    }
}