/*
 * Copyright(c) 2019 Samsung Electronics Co., Ltd.
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

using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Tizen.NUI
{
    internal static partial class Interop
    {
        internal static partial class Accessibility
        {
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void SayCallback(string status);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern void Say(string arg1_text, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool arg2_discardable, SayCallback arg3_callback);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern void PauseResume([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void StopReading([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool SuppressScreenReader([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void BridgeEnableAutoInit();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void BridgeDisableAutoInit();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool IsEnabled();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            [return: MarshalAs(UnmanagedType.U1)]
            public static partial bool IsScreenReaderEnabled();

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            public delegate void EnabledDisabledSignalHandler();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void RegisterEnabledDisabledSignalHandler(EnabledDisabledSignalHandler enabledSignalHandler, EnabledDisabledSignalHandler disabledSignalHandler);

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void RegisterScreenReaderEnabledDisabledSignalHandler(EnabledDisabledSignalHandler enabledSignalHandler, EnabledDisabledSignalHandler disabledSignalHandler);
        }
    }
}







