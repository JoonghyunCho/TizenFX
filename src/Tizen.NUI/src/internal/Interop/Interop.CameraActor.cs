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
            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_TYPE_get")]
            public static partial int TypeGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_PROJECTION_MODE_get")]
            public static partial int ProjectionModeGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_FIELD_OF_VIEW_get")]
            public static partial int FieldOfViewGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_ASPECT_RATIO_get")]
            public static partial int AspectRatioGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_NEAR_PLANE_DISTANCE_get")]
            public static partial int NearPlaneDistanceGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_FAR_PLANE_DISTANCE_get")]
            public static partial int FarPlaneDistanceGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_LEFT_PLANE_DISTANCE_get")]
            public static partial int LeftPlaneDistanceGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_RIGHT_PLANE_DISTANCE_get")]
            public static partial int RightPlaneDistanceGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_TOP_PLANE_DISTANCE_get")]
            public static partial int TopPlaneDistanceGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_BOTTOM_PLANE_DISTANCE_get")]
            public static partial int BottomPlaneDistanceGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_TARGET_POSITION_get")]
            public static partial int TargetPositionGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_PROJECTION_MATRIX_get")]
            public static partial int ProjectionMatrixGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_VIEW_MATRIX_get")]
            public static partial int ViewMatrixGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Property_INVERT_Y_AXIS_get")]
            public static partial int InvertYAxisGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_New__SWIG_0")]
            public static partial global::System.IntPtr New();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_New__SWIG_1")]
            public static partial global::System.IntPtr New([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_CameraActor")]
            public static partial void DeleteCameraActor([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_CameraActor__SWIG_1")]
            public static partial global::System.IntPtr NewCameraActor([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_Assign")]
            public static partial global::System.IntPtr Assign([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetType")]
            public static partial void SetType([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetType")]
            public static partial int GetType([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetProjectionMode")]
            public static partial void SetProjectionMode([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetProjectionMode")]
            public static partial int GetProjectionMode([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetFieldOfView")]
            public static partial void SetFieldOfView([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetFieldOfView")]
            public static partial float GetFieldOfView([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetAspectRatio")]
            public static partial void SetAspectRatio([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetAspectRatio")]
            public static partial float GetAspectRatio([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetNearClippingPlane")]
            public static partial void SetNearClippingPlane([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetNearClippingPlane")]
            public static partial float GetNearClippingPlane([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetFarClippingPlane")]
            public static partial void SetFarClippingPlane([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetFarClippingPlane")]
            public static partial float GetFarClippingPlane([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetTargetPosition")]
            public static partial void SetTargetPosition([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetTargetPosition")]
            public static partial global::System.IntPtr GetTargetPosition([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetInvertYAxis")]
            public static partial void SetInvertYAxis([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_GetInvertYAxis")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool GetInvertYAxis([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetPerspectiveProjection")]
            public static partial void SetPerspectiveProjection([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_CameraActor_SetOrthographicProjection__SWIG_0")]
            public static partial void SetOrthographicProjection([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);
        }
    }
}


