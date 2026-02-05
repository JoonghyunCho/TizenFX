using System;
using System.Runtime.InteropServices;

namespace Tizen.WindowSystem.Shell.SafeHandles
{
    internal class TizenRegionHandle : SafeHandle
    {
        public TizenRegionHandle() : base(IntPtr.Zero, true)
        {
        }

        public TizenRegionHandle(IntPtr handle, bool ownsHandle) : base(IntPtr.Zero, ownsHandle)
        {
            SetHandle(handle);
        }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            Interop.TizenRegion.Destroy(handle);
            return true;
        }
    }
}
