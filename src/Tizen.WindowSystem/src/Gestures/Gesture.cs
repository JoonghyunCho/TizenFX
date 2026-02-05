using System;
using System.ComponentModel;

namespace Tizen.WindowSystem
{
    /// <summary>
    /// Base class for Tizen Input Gestures.
    /// </summary>
    /// This class is need to be hidden as inhouse API.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class Gesture : IDisposable
    {
        internal SafeHandles.InputGestureHandle _handler;
        internal IntPtr _data;
        private bool disposed = false;
        internal InputGesture _parent;

        internal Gesture(InputGesture parent, SafeHandles.InputGestureHandle handler, IntPtr data)
        {
            _parent = parent;
            _handler = handler;
            _data = data;
        }

        /// <summary>
        /// Dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc/>
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                // Managed resources if any
            }
            
            if (_data != IntPtr.Zero && !_handler.IsInvalid)
            {
                FreeNative();
                _data = IntPtr.Zero;
            }
            
            disposed = true;
        }

        internal abstract void FreeNative();

        internal void ThrowIfError(Interop.InputGesture.ErrorCode error)
        {
             if (error == Interop.InputGesture.ErrorCode.None) return;
             // Reusing the same exception logic as InputGesture. 
             // Ideally this helper should be static or shared.
             // For now duplicating or I can make InputGesture's method static internal?
             // Let's copy simple switch or use a helper class?
             // Interop.InputGesture has ErrorCode enum.
             // I will duplicate logic for now to avoid cross-dependency on non-static member of InputGesture
             // OR I can add a static helper in InputGesture.
             throw new InvalidOperationException($"Gesture Error: {error}");
        }

        /// <summary>
        /// Grabs the gesture.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when operation fails.</exception>
        public void Grab()
        {
            Interop.InputGesture.ErrorCode res = Interop.InputGesture.GestureGrab(_handler, _data);
            if (res != Interop.InputGesture.ErrorCode.None)
                throw new InvalidOperationException($"Failed to grab gesture: {res}");
        }

        /// <summary>
        /// Ungrabs the gesture.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when operation fails.</exception>
        public void Ungrab()
        {
            Interop.InputGesture.ErrorCode res = Interop.InputGesture.GestureUngrab(_handler, _data);
             if (res != Interop.InputGesture.ErrorCode.None)
                throw new InvalidOperationException($"Failed to ungrab gesture: {res}");
        }

        /// <summary>
        /// Sets the grab mode of the gesture.
        /// </summary>
        /// <param name="mode">The mode of gesture grab.</param>
         /// <exception cref="InvalidOperationException">Thrown when operation fails.</exception>
        public void SetGrabMode(GestureGrabMode mode)
        {
            Interop.InputGesture.ErrorCode res = Interop.InputGesture.SetGestureGrabMode(_handler, _data, mode);
            if (res != Interop.InputGesture.ErrorCode.None)
                throw new InvalidOperationException($"Failed to set grab mode: {res}");
        }
    }
}
