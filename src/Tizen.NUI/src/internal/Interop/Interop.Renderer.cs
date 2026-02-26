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
        internal static partial class Renderer
        {
            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RangesBackgroundEffectGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RangesBackgroundGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RangesContentGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RangesDecorationGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RangesForegroundEffectGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int DepthIndexGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int FaceCullingModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendEquationRgbGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendEquationAlphaGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendFactorSrcRgbGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendFactorDestRgbGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendFactorSrcAlphaGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendFactorDestAlphaGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendColorGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendPreMultipliedAlphaGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int IndexRangeFirstGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int IndexRangeCountGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int DepthWriteModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int DepthFunctionGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int DepthTestModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RenderModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int StencilFunctionGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int StencilFunctionMaskGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int StencilFunctionReferenceGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int StencilMaskGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int StencilOperationOnFailGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int StencilOperationOnZFailGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int StencilOperationOnZPassGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int MixColorGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int MixColorRedGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int MixColorGreenGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int MixColorBlueGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int MixColorOpacityGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RenderingBehaviorGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int BlendEquationGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int InstanceCountGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int UpdateAreaExtentsGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Renderer_New")]
            public static extern global::System.IntPtr New(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Renderer")]
            public static extern void DeleteRenderer(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Renderer_SetGeometry")]
            public static extern void SetGeometry(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Renderer_SetIndexRange")]
            public static extern void SetIndexRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Renderer_SetTextures")]
            public static extern void SetTextures(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Renderer_GetTextures")]
            public static extern global::System.IntPtr GetTextures(global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Renderer_SetShader")]
            public static extern void SetShader(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);
        }
    }
}








