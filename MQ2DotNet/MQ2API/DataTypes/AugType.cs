﻿// ReSharper disable UnusedMember.Global

namespace MQ2DotNet.MQ2API.DataTypes
{
    public class AugType : MQ2DataType
    {
        /// <summary>
        /// Slot number of the augment on the item
        /// </summary>
        public IntType Slot => GetMember<IntType>("Slot");

        /// <summary>
        /// Type of the augmentation
        /// </summary>
        public IntType Type => GetMember<IntType>("Type");

        /// <summary>
        /// TODO: What does AugType.Visible mean?
        /// </summary>
        public BoolType Visible => GetMember<BoolType>("Visible");

        /// <summary>
        /// TODO: What does AugType.Infusable mean?
        /// </summary>
        public BoolType Infusable => GetMember<BoolType>("Infusable");

        /// <summary>
        /// True if the slot is empty
        /// </summary>
        public BoolType Empty => GetMember<BoolType>("Empty");

        /// <summary>
        /// Name of the augmentation in the slot
        /// </summary>
        public StringType Name => GetMember<StringType>("Name");

        /// <summary>
        /// Item in the augmentation slot
        /// </summary>
        public ItemType Item => GetMember<ItemType>("Item");

        /// <summary>
        /// Solvent required to remove the augmentation
        /// </summary>
        public SolventType Solvent => GetMember<SolventType>("Solvent");
    }
}