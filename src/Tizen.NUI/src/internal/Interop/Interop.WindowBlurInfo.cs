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

using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Tizen.NUI
{
    internal static partial class Interop
    {
        internal static partial class WindowBlurInfo
        {
            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New(int nuiBlurType, int nuiBlurRadius, int nuiCornerRadius);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New(int nuiBlurType, int nuiBlurRadius);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New(int nuiBlurType, int nuiBlurRadius, int nuiCornerRadius, global::System.IntPtr nuiDimInfo);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern void DeleteWindowBlurInfo(global::System.IntPtr nuiWindowBlurInfo);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int GetBlurType(global::System.IntPtr nuiWindowBlurInfo);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int GetBlurRadius(global::System.IntPtr nuiWindowBlurInfo);

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int GetBackgroundCornerRadius(global::System.IntPtr nuiWindowBlurInfo);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern void SetBehindBlurDimInfo(global::System.IntPtr nuiWindowBlurInfo, global::System.IntPtr nuiDimInfo);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr GetBehindBlurDimInfo(global::System.IntPtr nuiWindowBlurInfo);
        }

        internal static partial class WindowDimInfo
        {
            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New(int enable, global::System.IntPtr dimColor);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern void DeleteWindowDimInfo(global::System.IntPtr nuiWindowDimInfo);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int GetIsEnabled(global::System.IntPtr nuiWindowDimInfo);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr GetDimColor(global::System.IntPtr nuiWindowDimInfo);
        }
    }
}








