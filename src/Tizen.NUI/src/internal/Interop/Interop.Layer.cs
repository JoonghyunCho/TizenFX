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
        internal static partial class Layer
        {

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_Property_BEHAVIOR_get")]
            public static partial int BehaviorGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_New")]
            public static partial global::System.IntPtr New();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Layer")]
            public static partial void DeleteLayer(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_RaiseToTop")]
            public static partial void RaiseToTop(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_LowerToBottom")]
            public static partial void LowerToBottom(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_MoveAbove")]
            public static partial void MoveAbove(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_MoveBelow")]
            public static partial void MoveBelow(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_SetBehavior")]
            public static partial void SetBehavior(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_GetBehavior")]
            public static partial int GetBehavior(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_SetClipping")]
            public static partial void SetClipping(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_IsClipping")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsClipping(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_SetClippingBox__SWIG_1")]
            public static partial void SetClippingBox(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_GetClippingBox")]
            public static partial global::System.IntPtr GetClippingBox(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_SetTouchConsumed")]
            public static partial void SetTouchConsumed(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_IsTouchConsumed")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsTouchConsumed(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_SetHoverConsumed")]
            public static partial void SetHoverConsumed(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Layer_IsHoverConsumed")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsHoverConsumed(global::System.Runtime.InteropServices.HandleRef jarg1);
        }
    }
}
