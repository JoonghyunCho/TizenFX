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

using global::System.Runtime.InteropServices;

namespace Tizen.NUI
{
    internal static partial class Interop
    {
        internal static partial class View
        {
            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_New")]
            public static partial global::System.IntPtr New();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_NewCustom")]
            public static partial global::System.IntPtr NewCustom();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_NewWithBehaviour")]
            public static partial global::System.IntPtr NewWithBehaviour(int behaviour);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_NewCustomWithBehaviour")]
            public static partial global::System.IntPtr NewCustomWithBehaviour(int behaviour);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_View")]
            public static partial void DeleteView(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_View")]
            public static partial void DeleteControlHandleView(global::System.IntPtr jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DownCast")]
            public static partial global::System.IntPtr DownCast(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_HasKeyInputFocus")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool HasKeyInputFocus(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_SetStyleName", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void SetStyleName(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetStyleName", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial string GetStyleName(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_ClearBackground")]
            public static partial void ClearBackground(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_SetRenderEffect")]
            public static partial void SetRenderEffect(global::System.Runtime.InteropServices.HandleRef self, global::System.Runtime.InteropServices.HandleRef effectRef);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetRenderEffect")]
            public static partial global::System.IntPtr GetRenderEffect(global::System.Runtime.InteropServices.HandleRef self);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetOffScreenRenderingOutput")]
            public static partial global::System.IntPtr GetOffScreenRenderingOutput(global::System.Runtime.InteropServices.HandleRef self);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_ClearRenderEffect")]
            public static partial void ClearRenderEffect(global::System.Runtime.InteropServices.HandleRef self);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_View__SWIG_2")]
            public static partial global::System.IntPtr NewViewInternal(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetVisualResourceStatus")]
            public static partial int GetVisualResourceStatus(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_CreateTransition")]
            public static partial global::System.IntPtr CreateTransition(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DoAction")]
            public static partial void DoAction(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3, global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetVisualProperty")]
            public static partial global::System.IntPtr GetVisualProperty(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_IsResourceReady")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsResourceReady(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_ResourceReadySignal")]
            public static partial global::System.IntPtr ResourceReadySignal(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetVisualResourceStatus")]
            public static partial int View_GetVisualResourceStatus(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DoActionExtension", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void DoActionExtension(global::System.Runtime.InteropServices.HandleRef control, int visualIndex, int actionId, int id, string keyPath, int property, global::System.IntPtr callback);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DoActionWithEmptyAttributes")]
            public static partial void DoActionWithEmptyAttributes(HandleRef control, int visualIndex, int actionId);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DoActionWithSingleIntAttributes")]
            public static partial void DoActionWithSingleIntAttributes(HandleRef control, int visualIndex, int actionId, int actionValue);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyBool")]
            public static partial int InternalUpdateVisualPropertyBool(HandleRef control, int visualIndex, int visualPropertyIndex, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool valBool);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyFloat")]
            public static partial int InternalUpdateVisualPropertyFloat(HandleRef control, int visualIndex, int visualPropertyIndex, float valFloat);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyInt")]
            public static partial int InternalUpdateVisualPropertyInt(HandleRef control, int visualIndex, int visualPropertyIndex, int valInt);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyIntPair")]
            public static partial int InternalUpdateVisualPropertyIntPair(HandleRef control, int visualIndex, int visualPropertyIndex, int valInt1, int valInt2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyString", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int InternalUpdateVisualPropertyString(HandleRef control, int visualIndex, int visualPropertyIndex, string valString);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyStringPair", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int InternalUpdateVisualPropertyStringPair(HandleRef control, int visualIndex, int visualPropertyIndex, string valString1, string valString2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyVector4")]
            public static partial int InternalUpdateVisualPropertyVector4(HandleRef control, int visualIndex, int visualPropertyIndex, HandleRef vector4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InternalRetrievingVisualPropertyInt")]
            public static partial int InternalRetrievingVisualPropertyInt(HandleRef actor,  int visualIndex, int visualPropertyIndex, out int valInt);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InternalRetrievingVisualPropertyString", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int InternalRetrievingVisualPropertyString(HandleRef actor,  int visualIndex, int visualPropertyIndex, out string valString);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InternalRetrievingVisualPropertyVector4")]
            public static partial int InternalRetrievingVisualPropertyVector4(HandleRef actor,  int visualIndex, int visualPropertyIndex, HandleRef retrievingVector4);
        }
    }
}
