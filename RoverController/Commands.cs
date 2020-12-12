using System;
using System.Collections.Generic;
using System.Text;

namespace RoverController
{
    /// <summary>
    /// Available Commands
    /// </summary>
    public enum Commands
    {
        /// <summary>
        /// Advance
        /// </summary>
        A = 0,

        /// <summary>
        /// Turn Left
        /// </summary>
        L = -1,

        /// <summary>
        /// Turn Right
        /// </summary>
        R = 1
    }
}
