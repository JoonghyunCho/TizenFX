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
        internal static partial class Application
        {
            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_MakeCallback")]
            public static partial global::System.IntPtr MakeCallback(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_PreInitialize")]
            public static partial void PreInitialize();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_IsSupportPreInitializedCreation")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsSupportPreInitializedCreation();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_GetPreInitializeWindow")]
            public static partial global::System.IntPtr GetPreInitializeWindow();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_New__SWIG_0")]
            public static partial global::System.IntPtr New();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_New__SWIG_1")]
            public static partial global::System.IntPtr New(int jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_New__SWIG_2", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr New(int jarg1, string jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_New__SWIG_3", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr New(int jarg1, string jarg3, int jarg4);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Application__SWIG_0")]
            public static partial global::System.IntPtr NewApplication();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Application__SWIG_1")]
            public static partial global::System.IntPtr NewApplication(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_Assign")]
            public static partial global::System.IntPtr Assign(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Application")]
            public static partial void DeleteApplication(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_Lower")]
            public static partial void Lower(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_Quit")]
            public static partial void Quit(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_AddIdle")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool AddIdle(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_GetWindow")]
            public static partial global::System.IntPtr GetWindow(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_GetWindowsListSize")]
            public static partial uint GetWindowsListSize();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_GetWindowsFromList")]
            public static partial global::System.IntPtr GetWindowsFromList(uint jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_GetResourcePath", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial string GetResourcePath();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_GetLanguage", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial string GetLanguage(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_GetRegion", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial string GetRegion(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_New__SWIG_4", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr New(int jarg1, string jarg3, int jarg4, global::System.Runtime.InteropServices.HandleRef jarg5);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_New__SWIG_5", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr New(int argc, string argv, string styleSheet, int windowMode, global::System.Runtime.InteropServices.HandleRef initRectangle, int windowType);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_New__SWIG_6", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr New(int argc, string argv, string jarg3, int jarg4, global::System.Runtime.InteropServices.HandleRef jarg5, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool jarg7);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_New_WithWindowData", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr New(int argc, string argv, string styleSheet, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool uiThread, global::System.Runtime.InteropServices.HandleRef windowData);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_FlushUpdateMessages")]
            public static partial void FlushUpdateMessages(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetScreenSize")]
            public static partial global::System.IntPtr GetScreenSize();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_SetGeometryHittestEnabled")]
            public static partial void SetGeometryHittestEnabled([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool enable);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_IsGeometryHittestEnabled")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool IsGeometryHittestEnabled();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_GetAvailableScreens")]
            public static partial global::System.IntPtr GetAvailableScreens();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Application_SetApplicationLocale", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void SetApplicationLocale(global::System.Runtime.InteropServices.HandleRef application, string locale);
        }
    }
}
