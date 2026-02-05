using System.ComponentModel;

namespace Tizen.WindowSystem.Shell
{
    /// <summary>
    /// Enumeration for scrollable state of quickpanel service window.
    /// </summary>
    /// <since_tizen> 8 </since_tizen>
    public enum QuickPanelScrollableState
    {
        /// <summary>
        /// Unknown state. There is no quickpanel service.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        Unknown = 0x0,
        /// <summary>
        /// Scrollable state.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        Set = 0x1,
        /// <summary>
        /// Not scrollable state.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        Unset = 0x2,
        /// <summary>
        /// Retain scrollable state.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        Retain = 0x3,
    }
}
