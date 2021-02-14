using System;
using System.Collections.Generic;
using System.Text;

namespace KozzerWpf.Code
{
    /// <summary>
    /// Styles of page animations for appearing/disappearing
    /// </summary>
    public enum PageAnimation
    {
        /// <summary>
        /// No animation takes place
        /// </summary>
        None = 0,

        /// <summary>
        /// The page slides in and fades in from the left
        /// </summary>
        SlideAndFadeIn = 1,

        /// <summary>
        /// The page slides out and fades out to the left
        /// </summary>
        SlideAndFadeOut = 2,
    }
}
