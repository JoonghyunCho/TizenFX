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
        internal static partial class CameraActor
        {
            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TypeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ProjectionModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int FieldOfViewGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AspectRatioGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int NearPlaneDistanceGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int FarPlaneDistanceGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int LeftPlaneDistanceGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RightPlaneDistanceGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TopPlaneDistanceGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BottomPlaneDistanceGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TargetPositionGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ProjectionMatrixGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ViewMatrixGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int InvertYAxisGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_New__SWIG_1")]
            public static extern global::System.IntPtr New(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_CameraActor")]
            public static extern void DeleteCameraActor(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_CameraActor__SWIG_1")]
            public static extern global::System.IntPtr NewCameraActor(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Assign")]
            public static extern global::System.IntPtr Assign(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetType")]
            public static extern void SetType(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetType")]
            public static extern int GetType(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetProjectionMode")]
            public static extern void SetProjectionMode(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetProjectionMode")]
            public static extern int GetProjectionMode(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetFieldOfView")]
            public static extern void SetFieldOfView(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetFieldOfView")]
            public static extern float GetFieldOfView(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetAspectRatio")]
            public static extern void SetAspectRatio(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetAspectRatio")]
            public static extern float GetAspectRatio(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetNearClippingPlane")]
            public static extern void SetNearClippingPlane(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetNearClippingPlane")]
            public static extern float GetNearClippingPlane(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetFarClippingPlane")]
            public static extern void SetFarClippingPlane(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetFarClippingPlane")]
            public static extern float GetFarClippingPlane(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetTargetPosition")]
            public static extern void SetTargetPosition(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetTargetPosition")]
            public static extern global::System.IntPtr GetTargetPosition(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetInvertYAxis")]
            public static extern void SetInvertYAxis(global::System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetInvertYAxis")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static extern bool GetInvertYAxis(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetPerspectiveProjection")]
            public static extern void SetPerspectiveProjection(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetOrthographicProjection__SWIG_0")]
            public static extern void SetOrthographicProjection(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);
        }
    }
}








