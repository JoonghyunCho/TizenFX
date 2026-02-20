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
using System.Runtime.InteropServices;

namespace Tizen.NUI
{
    internal static partial class Interop
    {
        internal static partial class ActorSignal
        {
            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_HitTestResultSignal_Connect")]
            public static partial void HitTestResultConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_HitTestResultSignal_Disconnect")]
            public static partial void HitTestResultDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InterceptTouchedSignal_Connect")]
            public static partial void InterceptTouchConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InterceptTouchedSignal_Disconnect")]
            public static partial void InterceptTouchDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_TouchedSignal_Connect")]
            public static partial void TouchConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_TouchedSignal_Disconnect")]
            public static partial void TouchDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_HoveredSignal_Connect")]
            public static partial void HoveredConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_HoveredSignal_Disconnect")]
            public static partial void HoveredDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_WheelEventSignal_Connect")]
            public static partial void WheelEventConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_WheelEventSignal_Disconnect")]
            public static partial void WheelEventDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InterceptWheelSignal_Connect")]
            public static partial void InterceptWheelConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InterceptWheelSignal_Disconnect")]
            public static partial void InterceptWheelDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OnSceneSignal_Connect")]
            public static partial void OnSceneConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OnSceneSignal_Disconnect")]
            public static partial void OnSceneDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OffSceneSignal_Connect")]
            public static partial void OffSceneConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OffSceneSignal_Disconnect")]
            public static partial void OffSceneDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OnRelayoutSignal_Connect")]
            public static partial void OnRelayoutConnect(HandleRef actor, HandleRef hanlder);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OnRelayoutSignal_Disconnect")]
            public static partial void OnRelayoutDisconnect(HandleRef actor, HandleRef hanlder);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_VisibilityChangedSignal_Connect")]
            public static partial void VisibilityChangedConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_VisibilityChangedSignal_Disconnect")]
            public static partial void VisibilityChangedDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InheritedVisibilityChangedSignal_Connect")]
            public static partial void AggregatedVisibilityChangedConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InheritedVisibilityChangedSignal_Disconnect")]
            public static partial void AggregatedVisibilityChangedDisconnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_LayoutDirectionChangedSignal_Connect")]
            public static partial void LayoutDirectionChangedConnect(HandleRef actor, HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_LayoutDirectionChangedSignal_Disconnect")]
            public static partial void LayoutDirectionChangedDisconnect(HandleRef actor, HandleRef handler);
        }
    }
}
