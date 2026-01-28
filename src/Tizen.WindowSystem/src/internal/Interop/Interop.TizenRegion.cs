using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class TizenRegion
        {
            const string lib = "libtzsh_common.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_region_create")]
            internal static partial nint Create(nint tzsh);

            [LibraryImport(lib, EntryPoint = "tzsh_region_destroy")]
            internal static partial int Destroy(nint region);

            [LibraryImport(lib, EntryPoint = "tzsh_region_add")]
            internal static partial int Add(nint region, int x, int y, int w, int h);

            [LibraryImport(lib, EntryPoint = "tzsh_region_subtract")]
            internal static partial int Subtract(nint region, int x, int y, int w, int h);
        }
    }
}
