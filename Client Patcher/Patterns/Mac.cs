﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatcher.Patterns
{
    class Mac
    {
        public static class x64
        {
            public static byte[] CertBundleCASCLocalFile = { 0x48, 0x8D, 0x55, 0xDC, 0x31, 0xDB, 0x31, 0xC9 };
            public static byte[] CertBundleSignatureCheck = { 0x45, 0x84, 0xFF, 0xB0, 0x01, 0x75, 0x03, 0x44, 0x89 };
        }
    }
}
