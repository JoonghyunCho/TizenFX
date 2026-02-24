using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Tizen.NUI
{
    [CustomMarshaller(typeof(HandleRef), MarshalMode.ManagedToUnmanagedIn, typeof(HandleRefMarshaller))]
    internal ref struct HandleRefMarshaller
    {
        private object _wrapper;
        private IntPtr _handle;

        public void FromManaged(HandleRef managed)
        {
            _wrapper = managed.Wrapper;
            _handle = managed.Handle;
        }

        public IntPtr ToUnmanaged()
        {
            return _handle;
        }

        public void Free()
        {
            // Keep object alive until Free is called after the native call completes
            GC.KeepAlive(_wrapper);
        }
    }
}
