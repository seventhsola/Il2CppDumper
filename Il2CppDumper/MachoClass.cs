﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Il2CppDumper
{
    class MachoSection
    {
        public string section_name;
        public uint address;
        public uint size;
        public uint offset;
        public uint end;
    }

    class MachoSection64bit
    {
        public string section_name;
        public ulong address;
        public ulong size;
        public ulong offset;
        public ulong end;
    }

    class Fat
    {
        public uint file_offset;
        public uint size;
        public uint magic;
    }
}
