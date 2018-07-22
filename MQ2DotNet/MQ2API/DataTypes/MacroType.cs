﻿// ReSharper disable UnusedMember.Global

namespace MQ2DotNet.MQ2API.DataTypes
{
    public class MacroType : MQ2DataType
    {
        internal MacroType(MQ2TypeVar typeVar) : base(typeVar)
        {
            IsTLO = new IndexedMember<bool>(this, "IsTLO");
            IsOuterVariable = new IndexedMember<bool>(this, "IsOuterVariable");
        }

        /// <summary>
        /// Name of the currently running macro including extension e.g. kissassist.mac
        /// </summary>
        public string Name => GetMember<StringType>("Name");


        public long RunTime => GetMember<Int64Type>("RunTime");

        /// <summary>
        /// Macro currently paused?
        /// </summary>
        public bool Paused => GetMember<BoolType>("Paused");

        /// <summary>
        /// Value returned by the last subroutine call
        /// </summary>
        public string Return => GetMember<StringType>("Return");

        /// <summary>
        /// Is the given name a Top Level Object?
        /// </summary>
        public IndexedMember<bool> IsTLO { get; }

        /// <summary>
        /// Is the given name a variable declared with outer scope?
        /// </summary>
        public IndexedMember<bool> IsOuterVariable { get; }

        /// <summary>
        /// Stack depth of the currently executing macro
        /// </summary>
        public int StackSize => GetMember<IntType>("StackSize");

        /// <summary>
        /// Number of parameters supplied to the currently executing macro
        /// </summary>
        public int Params => GetMember<IntType>("Params");

        /// <summary>
        /// Line the currently executing macro is on
        /// </summary>
        public int CurLine => GetMember<IntType>("CurLine");

        /// <summary>
        /// Current command to be run by the executed macro
        /// </summary>
        public string CurCommand => GetMember<StringType>("CurCommand");

        /// <summary>
        /// Memory usage in bytes of the currently executing macro
        /// </summary>
        public int MemUse => GetMember<IntType>("MemUse");

        /// <summary>
        /// Prints undeclared variables to chat
        /// </summary>
        public void Undeclared() => GetMember<MQ2DataType>("Undeclared");
    }
}