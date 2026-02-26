using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
/*
 * Copyright(c) 2024 Samsung Electronics Co., Ltd.
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
        internal static partial class VisualObjectsContainer
        {
            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ContainerRangeTypeBackgroundEffectGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ContainerRangeTypeBackgroundGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ContainerRangeTypeContentGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ContainerRangeTypeDecorationGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int ContainerRangeTypeForegroundEffectGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr NewVisualObjectsContainer();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_VisualObjectsContainer_New")]
            public static extern global::System.IntPtr VisualObjectsContainerNew(global::System.Runtime.InteropServices.HandleRef view, int rangeType);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_VisualObjectsContainer_GetOwner")]
            public static extern global::System.IntPtr GetOwner(global::System.Runtime.InteropServices.HandleRef container);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_VisualObjectsContainer_GetContainerRangeType")]
            public static extern int GetContainerRangeType(global::System.Runtime.InteropServices.HandleRef container);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_VisualObjectsContainer_GetVisualObjectsCount")]
            public static extern uint GetVisualObjectsCount(global::System.Runtime.InteropServices.HandleRef container);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_VisualObjectsContainer_GetVisualObjectAt")]
            public static extern global::System.IntPtr GetVisualObjectAt(global::System.Runtime.InteropServices.HandleRef container, uint index);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_VisualObjectsContainer_AddVisualObject")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static extern bool AddVisualObject(global::System.Runtime.InteropServices.HandleRef container, global::System.Runtime.InteropServices.HandleRef viewObject);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_VisualObjectsContainer_AddShadowVisualObject")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static extern bool AddShadowVisualObject(global::System.Runtime.InteropServices.HandleRef container, global::System.Runtime.InteropServices.HandleRef viewObject, int shadowType);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_VisualObjectsContainer_RemoveVisualObject")]
            public static extern void RemoveVisualObject(global::System.Runtime.InteropServices.HandleRef container, global::System.Runtime.InteropServices.HandleRef viewObject);
        }
    }
}








