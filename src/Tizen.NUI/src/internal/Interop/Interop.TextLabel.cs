/*
 * Copyright(c) 2023 Samsung Electronics Co., Ltd.
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
        internal static partial class TextLabel
        {
            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TextGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int FontFamilyGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int FontStyleGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int PointSizeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int MultiLineGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int HorizontalAlignmentGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int VerticalAlignmentGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TextColorGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int EnableMarkupGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int EnableAutoScrollGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AutoScrollSpeedGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AutoScrollLoopCountGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AutoScrollGapGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int LineSpacingGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RelativeLineHeightGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int UnderlineGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ShadowGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int EmbossGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int OutlineGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New(bool hasStyle);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr New(string text, bool hasStyle);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_TextLabel")]
            public static extern void DeleteTextLabel(HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int PixelSizeGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int EllipsisGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int EllipsisPositionGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int LineCountGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int LineWrapModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TextDirectionGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int VerticalLineAlignmentGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AutoScrollStopModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AutoScrollLoopDelayGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int MatchSystemLanguageDirectionGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int TextFitGet();

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_TextFitChangedSignal")]
            public static extern global::System.IntPtr TextFitChangedSignal(HandleRef jarg1);

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int MinLineSizeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int FontSizeScaleGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int EnableFontSizeScaleGet();

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_GetTextSize")]
            public static extern global::System.IntPtr GetTextSize(HandleRef textLabelRef, uint start, uint end);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_GetTextPosition")]
            public static extern global::System.IntPtr GetTextPosition(HandleRef textLabelRef, uint start, uint end);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_SetTextFitArray")]
            public static extern void SetTextFitArray(HandleRef textLabel, bool enable, uint arraySize, float[] pointSizeArray, float[] minLineSizeArray);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_GetTextFitArray")]
            public static extern global::System.IntPtr GetTextFitArray(HandleRef textLabel);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_AnchorClickedSignal")]
            public static extern global::System.IntPtr AnchorClickedSignal(HandleRef jarg1);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabelSignal_Empty")]
            [return: MarshalAs(UnmanagedType.U1)]
            public static extern bool TextLabelSignalEmpty(HandleRef jarg1);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabelSignal_GetConnectionCount")]
            public static extern uint TextLabelSignalGetConnectionCount(HandleRef jarg1);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabelSignal_Connect")]
            public static extern void TextLabelSignalConnect(HandleRef jarg1, HandleRef jarg2);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabelSignal_Disconnect")]
            public static extern void TextLabelSignalDisconnect(HandleRef jarg1, HandleRef jarg2);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabelSignal_Emit")]
            public static extern void TextLabelSignalEmit(HandleRef jarg1, HandleRef jarg2);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern global::System.IntPtr NewTextLabelSignal();

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_TextLabelSignal")]
            public static extern void DeleteTextLabelSignal(HandleRef jarg1);

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int StrikethroughGet();

            [global::System.Runtime.InteropServices.DllImport(NDalicPINVOKE.Lib)]
            public static extern int CharacterSpacingGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AnchorColorGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AnchorClickedColorGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RemoveFrontInsetGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RemoveBackInsetGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int CutoutGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RenderModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int LayoutDirectionPolicyGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AutoScrollDirectionGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int EllipsisModeGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int IsScrollingGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int ManualRenderedGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int NeedRequestAsyncRenderGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int AsyncLineCountGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int RenderScaleGet();

            [LibraryImport(NDalicPINVOKE.Lib, StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial int PixelSnapFactorGet();

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RequestAsyncRenderWithFixedSize")]
            public static extern void RequestAsyncRenderWithFixedSize(HandleRef textLabelRef, float width, float height);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RequestAsyncRenderWithFixedWidth")]
            public static extern void RequestAsyncRenderWithFixedWidth(HandleRef textLabelRef, float width, float heightConstraint);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RequestAsyncRenderWithFixedHeight")]
            public static extern void RequestAsyncRenderWithFixedHeight(HandleRef textLabelRef, float widthConstraint, float height);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RequestAsyncRenderWithConstraint")]
            public static extern void RequestAsyncRenderWithConstraint(HandleRef textLabelRef, float widthConstraint, float heightConstraint);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RequestAsyncNaturalSize")]
            public static extern void RequestAsyncNaturalSize(HandleRef textLabelRef);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RequestAsyncHeightForWidth")]
            public static extern void RequestAsyncHeightForWidth(HandleRef textLabelRef, float width);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_AsyncTextRenderedSignal_Connect")]
            public static extern void AsyncTextRenderedConnect(HandleRef textLabelRef, HandleRef handler);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_AsyncTextRenderedSignal_Disconnect")]
            public static extern void AsyncTextRenderedDisconnect(HandleRef textLabelRef, HandleRef handler);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_AsyncNaturalSizeComputedSignal_Connect")]
            public static extern void AsyncNaturalSizeComputedConnect(HandleRef textLabelRef, HandleRef handler);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_AsyncNaturalSizeComputedSignal_Disconnect")]
            public static extern void AsyncNaturalSizeComputedDisconnect(HandleRef textLabelRef, HandleRef handler);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_AsyncHeightForWidthComputedSignal_Connect")]
            public static extern void AsyncHeightForWidthComputedConnect(HandleRef textLabelRef, HandleRef handler);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_AsyncHeightForWidthComputedSignal_Disconnect")]
            public static extern void AsyncHeightForWidthComputedDisconnect(HandleRef textLabelRef, HandleRef handler);
 
            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RegisterFontVariationProperty")]
            public static extern int RegisterFontVariationProperty(HandleRef textLabelRef, string pTag);
 
            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_SetMaskEffect")]
            public static extern void SetMaskEffect(HandleRef textLabelRef, HandleRef control);
 
            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RemoveMaskEffect")]
            public static extern void RemoveMaskEffect(HandleRef textLabelRef);

            [DllImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_TextLabel_RequestUpdateManually")]
            public static extern void RequestUpdateManually(HandleRef textLabelRef);
        }
    }
}








