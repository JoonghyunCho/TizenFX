using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
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
            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr NewCustom();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr NewWithBehaviour(int behaviour);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr NewCustomWithBehaviour(int behaviour);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_View")]
            public static extern void DeleteView(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern void DeleteControlHandleView(global::System.IntPtr jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DownCast")]
            public static extern global::System.IntPtr DownCast(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_HasKeyInputFocus")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static extern bool HasKeyInputFocus(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_SetStyleName")]
            public static extern void SetStyleName(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetStyleName")]
            public static extern string GetStyleName(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_ClearBackground")]
            public static extern void ClearBackground(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_SetRenderEffect")]
            public static extern void SetRenderEffect(global::System.Runtime.InteropServices.HandleRef self, global::System.Runtime.InteropServices.HandleRef effectRef);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetRenderEffect")]
            public static extern global::System.IntPtr GetRenderEffect(global::System.Runtime.InteropServices.HandleRef self);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetOffScreenRenderingOutput")]
            public static extern global::System.IntPtr GetOffScreenRenderingOutput(global::System.Runtime.InteropServices.HandleRef self);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_ClearRenderEffect")]
            public static extern void ClearRenderEffect(global::System.Runtime.InteropServices.HandleRef self);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_View__SWIG_2")]
            public static extern global::System.IntPtr NewViewInternal(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetVisualResourceStatus")]
            public static extern int GetVisualResourceStatus(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_CreateTransition")]
            public static extern global::System.IntPtr CreateTransition(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DoAction")]
            public static extern void DoAction(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3, global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetVisualProperty")]
            public static extern global::System.IntPtr GetVisualProperty(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_IsResourceReady")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static extern bool IsResourceReady(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_ResourceReadySignal")]
            public static extern global::System.IntPtr ResourceReadySignal(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_GetVisualResourceStatus")]
            public static extern int View_GetVisualResourceStatus(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DoActionExtension")]
            public static extern void DoActionExtension(global::System.Runtime.InteropServices.HandleRef control, int visualIndex, int actionId, int id, string keyPath, int property, global::System.IntPtr callback);


            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DoActionWithEmptyAttributes")]
            public static partial void DoActionWithEmptyAttributes(global::System.IntPtr control, int visualIndex, int actionId);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_DoActionWithSingleIntAttributes")]
            public static partial void DoActionWithSingleIntAttributes(global::System.IntPtr control, int visualIndex, int actionId, int actionValue);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyBool")]
            public static partial int InternalUpdateVisualPropertyBool(global::System.IntPtr control, int visualIndex, int visualPropertyIndex, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool valBool);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyFloat")]
            public static partial int InternalUpdateVisualPropertyFloat(global::System.IntPtr control, int visualIndex, int visualPropertyIndex, float valFloat);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyInt")]
            public static partial int InternalUpdateVisualPropertyInt(global::System.IntPtr control, int visualIndex, int visualPropertyIndex, int valInt);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyIntPair")]
            public static partial int InternalUpdateVisualPropertyIntPair(global::System.IntPtr control, int visualIndex, int visualPropertyIndex, int valInt1, int valInt2);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyString", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int InternalUpdateVisualPropertyString(global::System.IntPtr control, int visualIndex, int visualPropertyIndex, string valString);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyStringPair", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int InternalUpdateVisualPropertyStringPair(global::System.IntPtr control, int visualIndex, int visualPropertyIndex, string valString1, string valString2);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_View_InternalUpdateVisualPropertyVector4")]
            public static partial int InternalUpdateVisualPropertyVector4(global::System.IntPtr control, int visualIndex, int visualPropertyIndex, global::System.IntPtr vector4);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InternalRetrievingVisualPropertyInt")]
            public static partial int InternalRetrievingVisualPropertyInt(global::System.IntPtr actor,  int visualIndex, int visualPropertyIndex, out int valInt);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InternalRetrievingVisualPropertyString", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int InternalRetrievingVisualPropertyString(global::System.IntPtr actor,  int visualIndex, int visualPropertyIndex, out string valString);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InternalRetrievingVisualPropertyVector4")]
            public static partial int InternalRetrievingVisualPropertyVector4(global::System.IntPtr actor,  int visualIndex, int visualPropertyIndex, global::System.IntPtr retrievingVector4);
        }
    }
}









