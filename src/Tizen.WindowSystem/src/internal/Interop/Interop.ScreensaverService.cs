using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class ScreensaverService
        {
            const string lib = "libtzsh_screensaver_service.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_screensaver_service_create")]
            internal static partial nint Create(nint tzsh, uint win);

            [LibraryImport(lib, EntryPoint = "tzsh_screensaver_service_destroy")]
            internal static partial int Destroy(nint ScreensaverService);
        }
    }
}
