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
        internal static partial class ActorInternal
        {
            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_IsRoot")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsRoot(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_GetChildAt")]
            public static partial global::System.IntPtr GetChildAt(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetParentOrigin")]
            public static partial void SetParentOrigin(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetSize__SWIG_0")]
            public static partial void SetSize(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2, float jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetSize__SWIG_1")]
            public static partial void SetSize(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2, float jarg3, float jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetSize__SWIG_2")]
            public static partial void SetSizeVector2(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetSize__SWIG_3")]
            public static partial void SetSizeVector3(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetPosition__SWIG_0")]
            public static partial void SetPosition(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2, float jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetPosition__SWIG_1")]
            public static partial void SetPosition(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2, float jarg3, float jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetPosition__SWIG_2")]
            public static partial void SetPosition(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetX")]
            public static partial void SetX(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetY")]
            public static partial void SetY(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetZ")]
            public static partial void SetZ(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_TranslateBy")]
            public static partial void TranslateBy(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetInheritPosition")]
            public static partial void SetInheritPosition(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_IsPositionInherited")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsPositionInherited(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetOrientation__SWIG_0")]
            public static partial void SetOrientationDegree(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetOrientation__SWIG_1")]
            public static partial void SetOrientationRadian(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetOrientation__SWIG_2")]
            public static partial void SetOrientationQuaternion(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_RotateBy__SWIG_0")]
            public static partial void RotateByDegree(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_RotateBy__SWIG_1")]
            public static partial void RotateByRadian(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_RotateBy__SWIG_2")]
            public static partial void RotateByQuaternion(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_GetCurrentOrientation")]
            public static partial global::System.IntPtr GetCurrentOrientation(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetInheritOrientation")]
            public static partial void SetInheritOrientation(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_IsOrientationInherited")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsOrientationInherited(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_GetCurrentWorldOrientation")]
            public static partial global::System.IntPtr GetCurrentWorldOrientation(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetScale__SWIG_0")]
            public static partial void SetScale(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetScale__SWIG_1")]
            public static partial void SetScale(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2, float jarg3, float jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetScale__SWIG_2")]
            public static partial void SetScale(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_ScaleBy")]
            public static partial void ScaleBy(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_LookAt")]
            public static partial void LookAt(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, global::System.Runtime.InteropServices.HandleRef jarg3, global::System.Runtime.InteropServices.HandleRef jarg4, global::System.Runtime.InteropServices.HandleRef jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetInheritScale")]
            public static partial void SetInheritScale(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_IsScaleInherited")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsScaleInherited(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_GetCurrentWorldMatrix")]
            public static partial global::System.IntPtr GetCurrentWorldMatrix(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_IsVisible")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsVisible(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetOpacity")]
            public static partial void SetOpacity(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_GetCurrentOpacity")]
            public static partial float GetCurrentOpacity(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetColor")]
            public static partial void SetColor(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetColorMode")]
            public static partial void SetColorMode(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_GetColorMode")]
            public static partial int GetColorMode(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetDrawMode")]
            public static partial void SetDrawMode(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_GetDrawMode")]
            public static partial int GetDrawMode(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetKeyboardFocusable")]
            public static partial void SetKeyboardFocusable(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_IsKeyboardFocusable")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsKeyboardFocusable(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetKeyboardFocusableChildren")]
            public static partial void SetKeyboardFocusableChildren(global::System.Runtime.InteropServices.HandleRef manager, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool focusable);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_AreChildrenKeyBoardFocusable")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool AreChildrenKeyBoardFocusable(global::System.Runtime.InteropServices.HandleRef manager);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetTouchFocusable")]
            public static partial void SetFocusableInTouch(global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_IsTouchFocusable")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsFocusableInTouch(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetMinimumSize")]
            public static partial void SetMinimumSize(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_SetMaximumSize")]
            public static partial void SetMaximumSize(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_DevelActor_Property_SetTouchAreaOffset")]
            public static partial void SetTouchAreaOffset(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_DevelActor_Property_GetTouchAreaOffset")]
            public static partial void GetTouchAreaOffset(global::System.Runtime.InteropServices.HandleRef jarg1, out int jarg2, out int jarg3, out int jarg4, out int jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_RetrieveTargetSize")]
            public static partial int RetrieveTargetSize(HandleRef actor, HandleRef retrievingVector3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_RetrieveCurrentPropertyVector3")]
            public static partial int RetrieveCurrentPropertyVector3(HandleRef actor, int propertyType, HandleRef retrievingVector3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_RetrieveCurrentPropertyVector2ActualVector3")]
            public static partial int RetrieveCurrentPropertyVector2ActualVector3(HandleRef actor, int propertyType, HandleRef retrievingVector2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_RetrieveCurrentPropertyVector4")]
            public static partial int RetrieveCurrentPropertyVector4(HandleRef actor, int propertyType, HandleRef retrievingVector4);
        }
    }
}
