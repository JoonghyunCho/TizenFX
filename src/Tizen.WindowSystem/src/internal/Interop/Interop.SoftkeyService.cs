using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class SoftkeyService
        {
            const string lib = "libtzsh_softkey_service.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_service_create")]
            internal static partial nint Create(nint tzsh, uint win);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_service_destroy")]
            internal static partial int Destroy(nint softkeyService);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_service_show")]
            internal static partial int Show(nint softkeyService);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_service_hide")]
            internal static partial int Hide(nint softkeyService);

            internal delegate void SoftkeyVisibleEventCallback(nint data, nint softkeyService, int visible);
            [LibraryImport(lib, EntryPoint = "tzsh_softkey_service_visible_request_cb_set")]
            internal static partial int SetVisibleEventHandler(nint softkeyService, SoftkeyVisibleEventCallback func, nint data);

            internal delegate void SoftkeyExpandEventCallback(nint data, nint softkeyService, int expand);
            [LibraryImport(lib, EntryPoint = "tzsh_softkey_service_expand_request_cb_set")]
            internal static partial int SetExpandEventHandler(nint softkeyService, SoftkeyExpandEventCallback func, nint data);

            internal delegate void SoftkeyOpacityEventCallback(nint data, nint softkeyService, int opacity);
            [LibraryImport(lib, EntryPoint = "tzsh_softkey_service_opacity_request_cb_set")]
            internal static partial int SetOpacityEventHandler(nint softkeyService, SoftkeyOpacityEventCallback func, nint data);

            internal enum VisibleState
            {
                Hide = 0x0,
                Show = 0x1,
            }

            internal enum ExpandState
            {
                Off = 0x0,
                On = 0x1,
            }

            internal enum OpacityState
            {
                Opaque = 0x0,
                Transparent = 0x1,
            }
        }
    }
}
