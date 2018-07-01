﻿using System;
using System.Runtime.InteropServices;
// ReSharper disable UnusedMember.Global

namespace MQ2DotNet.MQ2API.DataTypes
{
    public class TimeType : MQ2DataType
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct tm
        {
            public int tm_sec;   // seconds after the minute - [0, 60] including leap second
            public int tm_min;   // minutes after the hour - [0, 59]
            public int tm_hour;  // hours since midnight - [0, 23]
            public int tm_mday;  // day of the month - [1, 31]
            public int tm_mon;   // months since January - [0, 11]
            public int tm_year;  // years since 1900
            public int tm_wday;  // days since Sunday - [0, 6]
            public int tm_yday;  // days since January 1 - [0, 365]
            public int tm_isdst; // daylight savings time flag
        };

        [Obsolete("Use conversion to DateTime")]
        public IntType Hour => GetMember<IntType>("Hour");

        [Obsolete("Use conversion to DateTime")]
        public StringType Hour12 => GetMember<StringType>("Hour12");

        [Obsolete("Use conversion to DateTime")]
        public IntType Minute => GetMember<IntType>("Minute");

        [Obsolete("Use conversion to DateTime")]
        public IntType Second => GetMember<IntType>("Second");

        [Obsolete("Use conversion to DateTime")]
        public IntType DayOfWeek => GetMember<IntType>("DayOfWeek");

        [Obsolete("Use conversion to DateTime")]
        public IntType Day => GetMember<IntType>("Day");

        [Obsolete("Use conversion to DateTime")]
        public IntType Month => GetMember<IntType>("Month");

        [Obsolete("Use conversion to DateTime")]
        public IntType Year => GetMember<IntType>("Year");

        [Obsolete("Use conversion to DateTime")]
        public StringType Time12 => GetMember<StringType>("Time12");

        [Obsolete("Use conversion to DateTime")]
        public StringType Time24 => GetMember<StringType>("Time24");

        [Obsolete("Use conversion to DateTime")]
        public StringType Date => GetMember<StringType>("Date");

        [Obsolete("Use conversion to DateTime")]
        public BoolType Night => GetMember<BoolType>("Night");

        [Obsolete("Use conversion to DateTime")]
        public IntType SecondsSinceMidnight => GetMember<IntType>("SecondsSinceMidnight");

        public static implicit operator DateTime(TimeType timeType)
        {
            var tm = Marshal.PtrToStructure<tm>(timeType.VarPtr.Ptr);
            return new DateTime(tm.tm_year, tm.tm_mon, tm.tm_mday, tm.tm_hour, tm.tm_min, tm.tm_sec);
        }
    }
}