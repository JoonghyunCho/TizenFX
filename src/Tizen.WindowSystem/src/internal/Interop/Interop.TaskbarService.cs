using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class TaskbarService
        {
            const string lib = "libtzsh_taskbar_service.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_taskbar_service_create")]
            internal static partial nint Create(nint tzsh, uint win);

            [LibraryImport(lib, EntryPoint = "tzsh_taskbar_service_destroy")]
            internal static partial int Destroy(nint taskbarService);

            [LibraryImport(lib, EntryPoint = "tzsh_taskbar_service_place_type_set")]
            internal static partial int SetPlaceType(nint taskbarService, int placeType);

            [LibraryImport(lib, EntryPoint = "tzsh_taskbar_service_size_set")]
            internal static partial int SetSize(nint taskbarService, uint width, uint height);
        }
    }
}
