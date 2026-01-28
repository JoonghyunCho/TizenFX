using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell
{
    internal static partial class Interop
    {
        internal static partial class KVMService
        {
            const string lib = "libtzsh_kvm_service.so.0";

            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_create")]
            internal static partial nint Create(nint tzsh, uint win);

            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_destroy")]
            internal static partial int Destroy(nint kvmService);

            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_perform_drop")]
            internal static partial int PerformDrop(nint kvmService);

            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_cancel_drag")]
            internal static partial int CancelDrag(nint kvmService);

            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_receive_drag_data", StringMarshalling = StringMarshalling.Utf8)]
            internal static partial int ReceiveDragData(nint kvmService, string mimeType);

            [global::System.Runtime.InteropServices.DllImport(lib, EntryPoint = "tzsh_kvm_service_get_source_mimetypes")]
            internal static extern int GetSourceMimetypes(
                nint kvmService,
                out string[] mimeTypes,
                out int count);

            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_secondary_selection_set")]
            internal static partial int SetSecondarySelection(nint kvmService);

            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_secondary_selection_unset")]
            internal static partial int UnsetSecondarySelection(nint kvmService);

            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_perform_drop_target")]
            internal static partial int PerformDropTarget(nint kvmService, uint drop_target);

            internal delegate void KVMDragStartEventCallback(nint data, nint kvmService);
            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_drag_start_cb_set")]
            internal static partial int SetDragStartEventHandler(nint kvmService, KVMDragStartEventCallback func, nint data);

            internal delegate void KVMDragEndEventCallback(nint data, nint kvmService);
            [LibraryImport(lib, EntryPoint = "tzsh_kvm_service_drag_end_cb_set")]
            internal static partial int SetDragEndEventHandler(nint kvmService, KVMDragEndEventCallback func, nint data);
        }
    }
}
