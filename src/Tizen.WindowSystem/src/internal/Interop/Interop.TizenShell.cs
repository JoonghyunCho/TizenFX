using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class TizenShell
        {
            const string lib = "libtzsh_common.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_create")]
            internal static partial nint Create(int type);

            [LibraryImport(lib, EntryPoint = "tzsh_destroy")]
            internal static partial int Destroy(nint tzsh);

            [LibraryImport(lib, EntryPoint = "tzsh_event_type_new", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial int NewEventType(nint tzsh, string name);

            internal enum ToolKitType
            {
                Unknown = 0,
                Efl = 1,
            }

            private const int ErrorTzsh = -0x02860000;

            internal enum ErrorCode
            {
                None = Tizen.Internals.Errors.ErrorCode.None,                            /* Successful */
                OutOfMemory = Tizen.Internals.Errors.ErrorCode.OutOfMemory,              /* Out of memory */
                InvalidParameter = Tizen.Internals.Errors.ErrorCode.InvalidParameter,    /* Invalid parameter */
                PermissionDenied = Tizen.Internals.Errors.ErrorCode.PermissionDenied,    /* Permission denied */
                NotSupported = Tizen.Internals.Errors.ErrorCode.NotSupported,            /* NOT supported */
                NoService = ErrorTzsh | 0x01,                                            /* Service does not exist */
            }
        }
    }
}
