using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class QuickPanelClient
        {
            const string lib = "libtzsh_quickpanel.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_create_with_type")]
            internal static partial nint CreateWithType(nint tzsh, uint win, int type);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_destroy")]
            internal static partial int Destroy(nint qpClient);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_visible_get")]
            internal static partial int GetVisible(nint qpClient, out int vis);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_scrollable_state_get")]
            internal static partial int GetScrollableState(nint qpClient, out int scroll);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_scrollable_state_set")]
            internal static partial int SetScrollableState(nint qpClient, int scroll);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_orientation_get")]
            internal static partial int GetOrientation(nint qpClient, out int orientation);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_show")]
            internal static partial int Show(nint qpClient);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_hide")]
            internal static partial int Hide(nint qpClient);

            internal delegate void QuickPanelEventCallback(int type, nint ev_info, nint data);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_event_handler_add")]
            internal static partial nint AddEventHandler(nint qpClient, int type, QuickPanelEventCallback func, nint data);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_event_handler_del")]
            internal static partial int DelEventHandler(nint qpClient, nint eventHandler);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_event_visible_get")]
            internal static partial int GetEventVisible(nint ev_info, out int state);

            [LibraryImport(lib, EntryPoint = "tzsh_quickpanel_event_orientation_get")]
            internal static partial int GetEventOrientation(nint ev_info, out int state);

            internal const string EventStringVisible = "tzsh_quickpanel_event_visible";
            internal const string EventStringOrientation = "tzsh_quickpanel_event_orientation";
        }
    }
}
