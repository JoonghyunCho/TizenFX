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
            public static partial void HitTestResultConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_HitTestResultSignal_Disconnect")]
            public static partial void HitTestResultDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InterceptTouchedSignal_Connect")]
            public static partial void InterceptTouchConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InterceptTouchedSignal_Disconnect")]
            public static partial void InterceptTouchDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_TouchedSignal_Connect")]
            public static partial void TouchConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_TouchedSignal_Disconnect")]
            public static partial void TouchDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_HoveredSignal_Connect")]
            public static partial void HoveredConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_HoveredSignal_Disconnect")]
            public static partial void HoveredDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_WheelEventSignal_Connect")]
            public static partial void WheelEventConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_WheelEventSignal_Disconnect")]
            public static partial void WheelEventDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InterceptWheelSignal_Connect")]
            public static partial void InterceptWheelConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InterceptWheelSignal_Disconnect")]
            public static partial void InterceptWheelDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OnSceneSignal_Connect")]
            public static partial void OnSceneConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OnSceneSignal_Disconnect")]
            public static partial void OnSceneDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OffSceneSignal_Connect")]
            public static partial void OffSceneConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OffSceneSignal_Disconnect")]
            public static partial void OffSceneDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OnRelayoutSignal_Connect")]
            public static partial void OnRelayoutConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef hanlder);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_OnRelayoutSignal_Disconnect")]
            public static partial void OnRelayoutDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef hanlder);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_VisibilityChangedSignal_Connect")]
            public static partial void VisibilityChangedConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_VisibilityChangedSignal_Disconnect")]
            public static partial void VisibilityChangedDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InheritedVisibilityChangedSignal_Connect")]
            public static partial void AggregatedVisibilityChangedConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_InheritedVisibilityChangedSignal_Disconnect")]
            public static partial void AggregatedVisibilityChangedDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_LayoutDirectionChangedSignal_Connect")]
            public static partial void LayoutDirectionChangedConnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Actor_LayoutDirectionChangedSignal_Disconnect")]
            public static partial void LayoutDirectionChangedDisconnect([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef actor, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef handler);
        }
    }
}

