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
using System;
using System.Runtime.InteropServices;

namespace Tizen.NUI
{
    internal static partial class Interop
    {
        internal static partial class PropertyMap
        {
            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property_Map__SWIG_0")]
            public static partial global::System.IntPtr NewPropertyMap();

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_new_Property_Map__SWIG_1")]
            public static partial global::System.IntPtr NewPropertyMap([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_delete_Property_Map")]
            public static partial void DeletePropertyMap([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Count")]
            public static partial uint Count([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Empty")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool Empty([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Insert__SWIG_0", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void Insert([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Insert__SWIG_2")]
            public static partial void Insert([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add__SWIG_0", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr Add([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add__SWIG_2")]
            public static partial global::System.IntPtr Add([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Remove__SWIG_0")]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool Remove([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Remove__SWIG_1", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
            public static partial bool Remove([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_GetValue")]
            public static partial global::System.IntPtr GetValue([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_GetKeyAt")]
            public static partial global::System.IntPtr GetKeyAt([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Find__SWIG_0", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr Find([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Find__SWIG_2")]
            public static partial global::System.IntPtr Find([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Find__SWIG_3", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr Find([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Clear")]
            public static partial void Clear([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Merge")]
            public static partial void Merge([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_ValueOfIndex__SWIG_0", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial global::System.IntPtr ValueOfIndex([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_ValueOfIndex__SWIG_2")]
            public static partial global::System.IntPtr ValueOfIndex([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_SetValue_StringKey", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial void SetValueStringKey([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [global::System.Runtime.InteropServices.LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_SetValue_IntKey")]
            public static partial void SetValueIntKey([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef jarg3);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_None")]
            public static partial IntPtr AddNone([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_None", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddNone([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_None")]
            public static partial IntPtr SetNone([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_None", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr SetNone([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Bool")]
            public static partial IntPtr AddBool([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Bool", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddBool([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Bool")]
            public static partial IntPtr SetBool([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Bool", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr SetBool([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Int")]
            public static partial IntPtr AddInt([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, int value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Int", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddInt([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, int value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Int")]
            public static partial IntPtr SetInt([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, int value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Int", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr SetInt([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, int value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Float")]
            public static partial IntPtr AddFloat([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, float value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Float", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddFloat([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, float value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Float")]
            public static partial IntPtr SetFloat([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, float value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Float", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr SetFloat([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, float value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Str", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddString([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, string value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Str", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddString([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, string value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Str", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr SetString([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, string value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_Str", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr SetString([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, string value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Vector2")]
            public static partial IntPtr AddVector2([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_Vector2", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddVector2([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_NVector2")]
            public static partial IntPtr AddVector2([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, float x, float y);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_NVector2", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddVector2([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, float x, float y);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_NVector2")]
            public static partial IntPtr SetVector2([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, float x, float y);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_NVector2", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr SetVector2([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, float x, float y);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Vector3")]
            public static partial IntPtr AddVector3([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Vector4")]
            public static partial IntPtr AddVector4([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_NVector4")]
            public static partial IntPtr AddVector4([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, float x, float y, float z, float w);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Str_NVector4", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr AddVector4([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, float x, float y, float z, float w);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_NVector4")]
            public static partial IntPtr SetVector4([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, float x, float y, float z, float w);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Str_NVector4", StringMarshalling = global::System.Runtime.InteropServices.StringMarshalling.Utf8)]
            public static partial IntPtr SetVector4([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, string key, float x, float y, float z, float w);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Rectangle")]
            public static partial IntPtr AddRectangle([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Set_Int_Rectangle")]
            public static partial IntPtr SetRectangle([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef value);

            [LibraryImport(NDalicPINVOKE.Lib, EntryPoint = "CSharp_Dali_Property_Map_Add_Int_Map")]
            public static partial IntPtr AddPropertyMap([global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef propertyMap, int key, [global::System.Runtime.InteropServices.Marshalling.MarshalUsing(typeof(global::Tizen.NUI.HandleRefMarshaller))] global::System.Runtime.InteropServices.HandleRef value);
        }
    }
}


