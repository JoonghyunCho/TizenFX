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
        internal static partial class Property
        {
            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_INVALID_INDEX_get")]
            public static partial int InvalidIndexGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_INVALID_KEY_get")]
            public static partial int InvalidKeyGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_INVALID_COMPONENT_INDEX_get")]
            public static partial int InvalidComponentIndexGet();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property__SWIG_0")]
            public static partial global::System.IntPtr NewProperty([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property__SWIG_2", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr NewProperty([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Property")]
            public static partial void DeleteProperty([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property__object_set")]
            public static partial void ObjectSet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property__object_get")]
            public static partial global::System.IntPtr ObjectGet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_propertyIndex_set")]
            public static partial void PropertyIndexSet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_propertyIndex_get")]
            public static partial int PropertyIndexGet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property_Array__SWIG_0")]
            public static partial global::System.IntPtr NewPropertyArray();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property_Array__SWIG_1")]
            public static partial global::System.IntPtr NewPropertyArray([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Property_Array")]
            public static partial void DeletePropertyArray([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_Size")]
            public static partial uint ArraySize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_Count")]
            public static partial uint ArrayCount([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_Empty")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool ArrayEmpty([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_Clear")]
            public static partial void ArrayClear([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_Reserve")]
            public static partial void ArrayReserve([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_Resize")]
            public static partial void ArrayResize([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_Capacity")]
            public static partial uint ArrayCapacity([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_PushBack")]
            public static partial void ArrayPushBack([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_Add")]
            public static partial global::System.IntPtr ArrayAdd([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_GetElementAt__SWIG_0")]
            public static partial global::System.IntPtr ArrayGetElementAt([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Array_ValueOfIndex__SWIG_0")]
            public static partial global::System.IntPtr ArrayValueOfIndex([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_type_set")]
            public static partial void KeyTypeSet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_type_get")]
            public static partial int KeyTypeGet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_indexKey_set")]
            public static partial void KeyIndexKeySet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_indexKey_get")]
            public static partial int KeyIndexKeyGet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_stringKey_set", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void KeyStringKeySet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_stringKey_get", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial string KeyStringKeyGet([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property_Key__SWIG_0", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr NewPropertyKey(string jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property_Key__SWIG_1")]
            public static partial global::System.IntPtr NewPropertyKey(int jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_EqualTo__SWIG_0", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool KeyEqualTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_EqualTo__SWIG_1")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool KeyEqualTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_EqualTo__SWIG_2")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool KeyEqualTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_NotEqualTo__SWIG_0", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool KeyNotEqualTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_NotEqualTo__SWIG_1")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool KeyNotEqualTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Key_NotEqualTo__SWIG_2")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool KeyNotEqualTo([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Property_Key")]
            public static partial void DeletePropertyKey([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);
        }
    }
}


