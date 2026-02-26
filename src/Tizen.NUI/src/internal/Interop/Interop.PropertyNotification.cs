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

namespace Tizen.NUI
{
    internal static partial class Interop
    {
        internal static partial class PropertyNotification
        {

            [LibraryImport(NDalicPINVOKE.Lib)]
            public static partial global::System.IntPtr NewPropertyNotification();

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_PropertyNotification")]
            public static partial void DeletePropertyNotification(global::System.IntPtr jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_PropertyNotification__SWIG_1")]
            public static partial global::System.IntPtr NewPropertyNotification(global::System.IntPtr jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_PropertyNotification_Assign")]
            public static partial global::System.IntPtr Assign(global::System.IntPtr jarg1, global::System.IntPtr jarg2);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_PropertyNotification_GetCondition__SWIG_0")]
            public static partial global::System.IntPtr GetCondition(global::System.IntPtr jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_PropertyNotification_GetTarget")]
            public static partial global::System.IntPtr GetTarget(global::System.IntPtr jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_PropertyNotification_GetTargetProperty")]
            public static partial int GetTargetProperty(global::System.IntPtr jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_PropertyNotification_SetNotifyMode")]
            public static partial void SetNotifyMode(global::System.IntPtr jarg1, int jarg2);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_PropertyNotification_GetNotifyMode")]
            public static partial int GetNotifyMode(global::System.IntPtr jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_PropertyNotification_GetNotifyResult")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GetNotifyResult(global::System.IntPtr jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_PropertyNotification_NotifySignal")]
            public static partial global::System.IntPtr NotifySignal(global::System.IntPtr jarg1);
        }
    }
}











