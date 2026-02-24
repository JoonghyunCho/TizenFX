/*
 * Copyright(c) 2021 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
namespace Tizen.NUI
{
    internal static partial class Interop
    {
        internal static partial class Window
        {
            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_New__SWIG_0", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr New([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_New__WithWindowData", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr New(string name, string className, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef windowData);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Window")]
            public static partial void DeleteWindow([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetClass", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void SetClass([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Raise")]
            public static partial void Raise([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Lower")]
            public static partial void Lower([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Activate")]
            public static partial void Activate([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_AddAvailableOrientation")]
            public static partial void AddAvailableOrientation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_RemoveAvailableOrientation")]
            public static partial void RemoveAvailableOrientation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetPreferredOrientation")]
            public static partial void SetPreferredOrientation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetPreferredOrientation")]
            public static partial int GetPreferredOrientation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetCurrentOrientation")]
            public static partial int GetCurrentOrientation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetAvailableOrientations")]
            public static partial void SetAvailableOrientations([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, int jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetPositionSize")]
            public static partial void SetPositionSize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_FocusChangedSignal")]
            public static partial global::System.IntPtr FocusChangedSignal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetAcceptFocus")]
            public static partial void SetAcceptFocus([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_IsFocusAcceptable")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsFocusAcceptable([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Show")]
            public static partial void Show([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Hide")]
            public static partial void Hide([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_IsVisible")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsVisible([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetSupportedAuxiliaryHintCount")]
            public static partial uint GetSupportedAuxiliaryHintCount([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetSupportedAuxiliaryHint", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial string GetSupportedAuxiliaryHint([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_AddAuxiliaryHint", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial uint AddAuxiliaryHint([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_RemoveAuxiliaryHint")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool RemoveAuxiliaryHint([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetAuxiliaryHintValue", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool SetAuxiliaryHintValue([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2, string jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetAuxiliaryHintValue", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial string GetAuxiliaryHintValue([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetAuxiliaryHintId", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial uint GetAuxiliaryHintId([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetInputRegion")]
            public static partial void SetInputRegion([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetType")]
            public static partial void SetType([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetType")]
            public static partial int GetType([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetNotificationLevel")]
            public static partial int SetNotificationLevel([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetNotificationLevel")]
            public static partial int GetNotificationLevel([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetOpaqueState")]
            public static partial void SetOpaqueState([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_IsOpaqueState")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsOpaqueState([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetScreenOffMode")]
            public static partial int SetScreenOffMode([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetScreenOffMode")]
            public static partial int GetScreenOffMode([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetBrightness")]
            public static partial int SetBrightness([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetBrightness")]
            public static partial int GetBrightness([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            // For windows resized signal
            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_ResizeSignal")]
            public static partial global::System.IntPtr ResizeSignal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetSize")]
            public static partial void SetSize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetSize")]
            public static partial global::System.IntPtr GetSize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetPosition")]
            public static partial void SetPosition([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetPosition")]
            public static partial global::System.IntPtr GetPosition([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetPartialUpdateEnabled")]
            public static partial void SetPartialUpdateEnabled([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool enabled);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IsPartialUpdateEnabled")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsPartialUpdateEnabled([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetTransparency")]
            public static partial global::System.IntPtr SetTransparency([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_FeedKey_Default_Window")]
            public static partial void FeedKeyEvent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_FeedKey")]
            public static partial void FeedKeyEvent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef keyEvent);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_FeedTouch")]
            public static partial void FeedTouchPoint([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef touchPoint, int timeStamp);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_FeedWheel")]
            public static partial void FeedWheelEvent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef wheelEvent);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_FeedHover")]
            public static partial void FeedHoverEvent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef touchPoint);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Adaptor_RenderOnce")]
            public static partial void RenderOnce([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Add")]
            public static partial void Add([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Remove")]
            public static partial void Remove([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetBackgroundColor")]
            public static partial void SetBackgroundColor([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetBackgroundColor")]
            public static partial global::System.IntPtr GetBackgroundColor([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetRootLayer")]
            public static partial global::System.IntPtr GetRootLayer([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetOverlayLayer")]
            public static partial global::System.IntPtr GetOverlayLayer([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_KeyEventSignal")]
            public static partial global::System.IntPtr KeyEventSignal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_InterceptKeyEventSignal")]
            public static partial global::System.IntPtr InterceptKeyEventSignal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GrabKeyTopmost")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GrabKeyTopmost(System.IntPtr Window, int DaliKey);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_UngrabKeyTopmost")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool UngrabKeyTopmost(System.IntPtr Window, int DaliKey);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GrabKey")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GrabKey(System.IntPtr Window, int DaliKey, int GrabMode);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_UngrabKey")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool UngrabKey(System.IntPtr Window, int DaliKey);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Keyboard_SetRepeatInfo")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool SetKeyboardRepeatInfo(float rate, float delay);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Keyboard_GetRepeatInfo")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GetKeyboardRepeatInfo(out float rate, out float delay);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Keyboard_Set_Horizental_RepeatInfo")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool SetKeyboardHorizentalRepeatInfo(float rate, float delay);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Keyboard_Get_Horizental_RepeatInfo")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GetKeyboardHorizentalRepeatInfo(out float rate, out float delay);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Keyboard_Set_Vertical_RepeatInfo")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool SetKeyboardVerticalRepeatInfo(float rate, float delay);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Keyboard_Get_Vertical_RepeatInfo")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GetKeyboardVerticalRepeatInfo(out float rate, out float delay);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetNativeWindowHandler")]
            public static partial System.IntPtr GetNativeWindowHandler(System.IntPtr Window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetParent")]
            public static partial void SetParent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetParent_With_Stack")]
            public static partial void SetParentWithStack([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef child, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef parent, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool belowParent);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Unparent")]
            public static partial void Unparent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetParent")]
            public static partial global::System.IntPtr GetParent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetNativeId")]
            public static partial int GetNativeId([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_EnableFloatingMode")]
            public static partial void EnableFloatingMode([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IsFloatingModeEnabled")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsFloatingModeEnabled([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_RequestMoveToServer")]
            public static partial void RequestMoveToServer([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_RequestResizeToServer")]
            public static partial void RequestResizeToServer([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetWindow")]
            public static partial global::System.IntPtr Get([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IncludeInputRegion")]
            public static partial void IncludeInputRegion([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef inputRegion);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_ExcludeInputRegion")]
            public static partial void ExcludeInputRegion([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef inputRegion);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Maximize")]
            public static partial void Maximize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool maximize);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IsMaximized")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsMaximized([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Set_Maximum_Size")]
            public static partial void SetMaximumSize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef size);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Minimize")]
            public static partial void Minimize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool minimize);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IsMinimized")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsMinimized([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Set_Minimum_Size")]
            public static partial void SetMimimumSize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef size);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_Maximize_With_RestoreSize")]
            public static partial void MaximizeWithRestoreSize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool maximize, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef size);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetLayout")]
            public static partial void SetLayout([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, uint numCols, uint numRows, uint column, uint row, uint colSpan, uint rowSpan);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IsWindowRotating")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsWindowRotating([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_InternalRetrievingLastKeyEvent")]
            public static partial void InternalRetrievingLastKeyEvent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef key);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_InternalRetrievingLastTouchEvent")]
            public static partial void InternalRetrievingLastTouchEvent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef touch);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_InternalRetrievingLastHoverEvent")]
            public static partial void InternalRetrievingLastHoverEvent([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef hover);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_InternalRetrievingLastPanGestureState")]
            public static partial int InternalRetrievingLastPanGestureState([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetNeedsRotationCompletedAcknowledgement")]
            public static partial void SetNeedsRotationCompletedAcknowledgement([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool needAcknowledgement);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SendRotationCompletedAcknowledgement")]
            public static partial void SendRotationCompletedAcknowledgement([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_KeepRendering")]
            public static partial void KeepRendering([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, float durationSeconds);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_PointerConstraintsLock")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool PointerConstraintsLock([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_PointerConstraintsUnlock")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool PointerConstraintsUnlock([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_LockedPointerRegionSet")]
            public static partial void LockedPointerRegionSet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, int x, int y, int w, int h);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_LockedPointerCursorPositionHintSet")]
            public static partial void LockedPointerCursorPositionHintSet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, int x, int y);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_PointerWarp")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool PointerWarp([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, int x, int y);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_CursorVisibleSet")]
            public static partial void CursorVisibleSet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool visible);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_KeyboardGrab")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool KeyboardGrab([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, uint deviceSubclass);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_KeyboardUnGrab")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool KeyboardUnGrab([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetFullScreen")]
            public static partial void SetFullScreen([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool fullscreen);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetFullScreen")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GetFullScreen([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetModal")]
            public static partial void SetModal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool modal);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IsModal")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsModal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetAlwaysOnTop")]
            public static partial void SetAlwaysOnTop([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool alwaysTop);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IsAlwaysOnTop")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsAlwaysOnTop([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetBottom")]
            public static partial void SetBottom([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool enable);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_IsBottom")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsBottom([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_RelativeMotionGrab")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool RelativeMotionGrab([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, uint boundary);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_RelativeMotionUnGrab")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool RelativeMotionUnGrab([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetBlur")]
            public static partial void SetBlur([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, global::System.IntPtr blurInfo);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetBlur")]
            public static partial global::System.IntPtr GetBlur([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetInsets__SWIG_0")]
            public static partial global::System.IntPtr GetInsets([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetInsets__SWIG_1")]
            public static partial global::System.IntPtr GetInsets([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, int insetsFlags);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetScreen", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void SetScreen([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, string name);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetScreen", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial string GetScreen([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_SetFrontBufferRendering")]
            public static partial void SetFrontBufferRendering([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool enable);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Window_GetFrontBufferRendering")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GetFrontBufferRendering([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef window);
        }
    }
}


