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
        internal static partial class Animation
        {

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_New")]
            public static partial global::System.IntPtr New(float jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Animation")]
            public static partial void DeleteAnimation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Animation__SWIG_1")]
            public static partial global::System.IntPtr NewAnimation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Assign")]
            public static partial global::System.IntPtr Assign([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetDuration")]
            public static partial void SetDuration([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetDuration")]
            public static partial float GetDuration([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetLooping")]
            public static partial void SetLooping([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetLoopCount")]
            public static partial void SetLoopCount([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetLoopCount")]
            public static partial int GetLoopCount([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetCurrentLoop")]
            public static partial int GetCurrentLoop([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_IsLooping")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsLooping([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetEndAction")]
            public static partial void SetEndAction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetEndAction")]
            public static partial int GetEndAction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetDisconnectAction")]
            public static partial void SetDisconnectAction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetDisconnectAction")]
            public static partial int GetDisconnectAction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetDefaultAlphaFunction")]
            public static partial void SetDefaultAlphaFunction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetDefaultAlphaFunction")]
            public static partial global::System.IntPtr GetDefaultAlphaFunction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetCurrentProgress")]
            public static partial void SetCurrentProgress([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetCurrentProgress")]
            public static partial float GetCurrentProgress([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetSpeedFactor")]
            public static partial void SetSpeedFactor([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetSpeedFactor")]
            public static partial float GetSpeedFactor([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetPlayRange")]
            public static partial void SetPlayRange([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetPlayRange")]
            public static partial global::System.IntPtr GetPlayRange([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Play")]
            public static partial void Play([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_PlayFrom")]
            public static partial void PlayFrom([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Pause")]
            public static partial void Pause([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetState")]
            public static partial int GetState([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Stop")]
            public static partial void Stop([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Clear")]
            public static partial void Clear([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetLoopingMode")]
            public static partial void SetLoopingMode([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetLoopingMode")]
            public static partial int GetLoopingMode([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetAnimationId")]
            public static partial uint GetAnimationId([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef nuiAnimation);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetProgressNotification")]
            public static partial void SetProgressNotification([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetProgressNotification")]
            public static partial float GetProgressNotification([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_SetBlendPoint")]
            public static partial void SetBlendPoint([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef csAnimation, float blendPoint);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_GetBlendPoint")]
            public static partial float GetBlendPoint([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef csAnimation);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_FinishedSignal")]
            public static partial global::System.IntPtr FinishedSignal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_ProgressReachedSignal")]
            public static partial global::System.IntPtr ProgressReachedSignal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_PlayAfter")]
            public static partial void PlayAfter([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBy__SWIG_0")]
            public static partial void AnimateBy([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBy__SWIG_1")]
            public static partial void AnimateByAlphaFunction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBy__SWIG_2")]
            public static partial void AnimateByTimePeriod([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBy__SWIG_3")]
            public static partial void AnimateBy([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateTo__SWIG_0")]
            public static partial void AnimateTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateTo__SWIG_1")]
            public static partial void AnimateToAlphaFunction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateTo__SWIG_2")]
            public static partial void AnimateToTimePeriod([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateTo__SWIG_3")]
            public static partial void AnimateTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5);


            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBy__SWIG_0")]
            public static partial void AnimateBy([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, global::System.IntPtr jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBy__SWIG_1")]
            public static partial void AnimateByAlphaFunction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, global::System.IntPtr jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBy__SWIG_2")]
            public static partial void AnimateByTimePeriod([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, global::System.IntPtr jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBy__SWIG_3")]
            public static partial void AnimateBy([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, global::System.IntPtr jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateTo__SWIG_0")]
            public static partial void AnimateTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, global::System.IntPtr jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateTo__SWIG_1")]
            public static partial void AnimateToAlphaFunction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, global::System.IntPtr jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateTo__SWIG_2")]
            public static partial void AnimateToTimePeriod([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, global::System.IntPtr jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateTo__SWIG_3")]
            public static partial void AnimateTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, global::System.IntPtr jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBetween__SWIG_0")]
            public static partial void AnimateBetween([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBetween__SWIG_1")]
            public static partial void AnimateBetween([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, int jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBetween__SWIG_2")]
            public static partial void AnimateBetweenAlphaFunction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBetween__SWIG_3")]
            public static partial void AnimateBetweenAlphaFunctionInterpolation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, int jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBetween__SWIG_4")]
            public static partial void AnimateBetweenTimePeriod([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBetween__SWIG_5")]
            public static partial void AnimateBetweenTimePeriodInterpolation([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, int jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBetween__SWIG_6")]
            public static partial void AnimateBetween([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_AnimateBetween__SWIG_7")]
            public static partial void AnimateBetween([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5, int jarg6);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Animate__SWIG_0")]
            public static partial void Animate([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Animate__SWIG_1")]
            public static partial void AnimateAlphaFunction([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Animate__SWIG_2")]
            public static partial void AnimateTimePeriod([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Animate__SWIG_3")]
            public static partial void Animate([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg4, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg5, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg6);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Show")]
            public static partial void Show([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, float jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Animation_Hide")]
            public static partial void Hide([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2, float jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_AnimationSignal_Empty")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool AnimationSignalEmpty([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_AnimationSignal_GetConnectionCount")]
            public static partial uint AnimationSignalGetConnectionCount([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_AnimationSignal_Connect")]
            public static partial void AnimationSignalConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_AnimationSignal_Disconnect")]
            public static partial void AnimationSignalDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_AnimationSignal_Emit")]
            public static partial void AnimationSignalEmit([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_AnimationSignal")]
            public static partial global::System.IntPtr NewAnimationSignal();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_AnimationSignal")]
            public static partial void DeleteAnimationSignal([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);
        }
    }
}


