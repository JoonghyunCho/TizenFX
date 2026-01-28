using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class SoftkeyClient
        {
            const string lib = "libtzsh_softkey.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_create")]
            internal static partial nint Create(nint tzsh, uint win);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_destroy")]
            internal static partial int Destroy(nint softkeyClient);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_global_show")]
            internal static partial int Show(nint softkeyClient);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_global_hide")]
            internal static partial int Hide(nint softkeyClient);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_global_visible_state_get")]
            internal static partial int GetVisibleState(nint softkeyClient, out int visible);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_global_expand_state_set")]
            internal static partial int SetExpandState(nint softkeyClient, int expand);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_global_expand_state_get")]
            internal static partial int GetExpandState(nint softkeyClient, out int expand);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_global_opacity_state_set")]
            internal static partial int SetOpacityState(nint softkeyClient, int opacity);

            [LibraryImport(lib, EntryPoint = "tzsh_softkey_global_opacity_state_get")]
            internal static partial int GetOpacityState(nint softkeyClient, out int opacity);

            internal enum VisibleState
            {
                Unknown = 0x0,
                Shown = 0x1,
                Hidden = 0x2,
            }

            internal enum ExpandState
            {
                Unknown = 0x0,
                On = 0x1,
                Off = 0x2,
            }

            internal enum OpacityState
            {
                Unknown = 0x0,
                Opaque = 0x1,
                Transparent = 0x2,
            }
        }
    }
}
