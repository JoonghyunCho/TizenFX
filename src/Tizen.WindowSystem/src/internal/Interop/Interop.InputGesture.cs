using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

namespace Tizen.WindowSystem
{
    internal static partial class Interop
    {
        internal static partial class InputGesture
        {
            const string lib = "libcapi-ui-efl-util.so.0";

            internal static string LogTag = "Tizen.WindowSystem";

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_initialize")]
            internal static partial nint Initialize();

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_deinitialize")]
            internal static partial ErrorCode Deinitialize(nint gestureHandler);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_edge_swipe_new")]
            internal static partial nint EdgeSwipeNew(nint gestureHandler, int fingers, int edge);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_edge_swipe_free")]
            internal static partial ErrorCode EdgeSwipeFree(nint gestureHandler, nint gestureData);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_edge_swipe_size_set")]
            internal static partial ErrorCode EdgeSwipeSizeSet(nint gestureData, int edgeSize, int startPoint, int endPoint);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_edge_drag_new")]
            internal static partial nint EdgeDragNew(nint gestureHandler, int fingers, int edge);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_edge_drag_free")]
            internal static partial ErrorCode EdgeDragFree(nint gestureHandler, nint gestureData);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_edge_drag_size_set")]
            internal static partial ErrorCode EdgeDragSizeSet(nint gestureData, int edgeSize, int startPoint, int endPoint);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_tap_new")]
            internal static partial nint TapNew(nint gestureHandler, int fingers, int repeats);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_tap_free")]
            internal static partial ErrorCode TapFree(nint gestureHandler, nint gestureData);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_palm_cover_new")]
            internal static partial nint PalmCoverNew(nint gestureHandler);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_palm_cover_free")]
            internal static partial ErrorCode PalmCoverFree(nint gestureHandler, nint gestureData);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_grab")]
            internal static partial ErrorCode GestureGrab(nint gestureHandler, nint gestureData);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_grab_mode_set")]
            internal static partial ErrorCode SetGestureGrabMode(nint gestureHandler, nint gestureData, int mode);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_ungrab")]
            internal static partial ErrorCode GestureUngrab(nint gestureHandler, nint gestureData);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_edge_swipe_cb_set")]
            internal static partial ErrorCode SetEdgeSwipeCb(nint gestureHandler, EdgeSwipeCb cbFunc, nint usergestureData);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void EdgeSwipeCb(nint usergestureData, int mode, int fingers, int sx, int sy, int edge);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_edge_drag_cb_set")]
            internal static partial ErrorCode SetEdgeDragCb(nint gestureHandler, EdgeDragCb cbFunc, nint usergestureData);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void EdgeDragCb(nint usergestureData, int mode, int fingers, int cx, int cy, int edge);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_tap_cb_set")]
            internal static partial ErrorCode SetTapCb(nint gestureHandler, TapCb cbFunc, nint usergestureData);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void TapCb(nint usergestureData, int mode, int fingers, int repeats);

            [LibraryImport(lib, EntryPoint = "efl_util_gesture_palm_cover_cb_set")]
            internal static partial ErrorCode SetPalmCoverCb(nint gestureHandler, PalmCoverCb cbFunc, nint usergestureData);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            internal delegate void PalmCoverCb(nint usergestureData, int mode, int duration, int cx, int cy, int size, double pressure);

            internal enum ErrorCode
            {
                None = Tizen.Internals.Errors.ErrorCode.None,                            // Successful
                OutOfMemory = Tizen.Internals.Errors.ErrorCode.OutOfMemory,              // Out of memory
                InvalidParameter = Tizen.Internals.Errors.ErrorCode.InvalidParameter,    // Invalid parameter
                InvalidOperation = Tizen.Internals.Errors.ErrorCode.InvalidOperation,    // Invalid operation
                PermissionDenied = Tizen.Internals.Errors.ErrorCode.PermissionDenied,    // Permission denied
                NotSupported = Tizen.Internals.Errors.ErrorCode.NotSupported,            // NOT supported
            };
        }
    }
}
