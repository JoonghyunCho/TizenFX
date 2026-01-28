using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class QuickPanelService
        {
            const string lib = "libtzsh_quickpanel_service.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_create_with_type")]
            internal static partial nint CreateWithType(nint tzsh, uint win, int type);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_destroy")]
            internal static partial int Destroy(nint service);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_type_get")]
            internal static partial int GetType(nint service, out int type);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_show")]
            internal static partial int Show(nint service);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_hide")]
            internal static partial int Hide(nint service);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_content_region_set")]
            internal static partial int SetContentRegion(nint service, uint angle, nint region);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_handler_region_set")]
            internal static partial int SetHandlerRegion(nint service, uint angle, nint region);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_effect_type_set")]
            internal static partial int SetEffectType(nint service, int type);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_service_scroll_lock")]
            internal static partial int LockScroll(nint service, [MarshalAs(UnmanagedType.I1)] bool locked);
        }
    }
}
