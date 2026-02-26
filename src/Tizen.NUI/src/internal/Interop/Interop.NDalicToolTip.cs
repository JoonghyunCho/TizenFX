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
        internal static partial class NDalicToolTip
        {
            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipContentGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipLayoutGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipWaitTimeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipBackgroundGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipTailGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipPositionGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipHoverPointOffsetGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipMovementThresholdGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipDisappearOnMovementGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipBackgroundVisualGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipBackgroundBorderGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipTailVisibilityGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipTailAboveVisualGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TooltipTailBelowVisualGet();
        }
    }
}






