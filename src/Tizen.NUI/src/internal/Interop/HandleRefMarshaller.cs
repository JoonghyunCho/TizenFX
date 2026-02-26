using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace Tizen.NUI
{
    [CustomMarshaller(typeof(HandleRef), MarshalMode.ManagedToUnmanagedIn, typeof(HandleRefMarshaller))]
    internal ref struct HandleRefMarshaller
    {
        private HandleRef _managed;

        public void FromManaged(HandleRef managed)
        {
            _managed = managed;
        }

        public IntPtr ToUnmanaged()
        {
            return _managed.Handle;
        }

        public void Free()
        {
            GC.KeepAlive(_managed.Wrapper);
        }
    }
}

