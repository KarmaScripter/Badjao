// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// 
    /// </summary>
    internal static class NativeMethods
    {
        /// <summary>
        /// Gets the handle of the window that currently has focus.
        /// </summary>
        /// <returns>
        /// The handle of the window that currently has focus.
        /// </returns>
        [ DllImport( "user32" ) ]
        internal static extern IntPtr GetForegroundWindow( );

        /// <summary>
        /// Activates the specified window.
        /// </summary>
        /// <param name="hWnd">
        /// The handle of the window to be focused.
        /// </param>
        /// <returns>
        /// True if the window was focused; False otherwise.
        /// </returns>
        [ DllImport( "user32" ) ]
        internal static extern bool SetForegroundWindow( IntPtr hWnd );

        /// <summary>
        /// Windows API function to animate a window.
        /// </summary>
        [ DllImport( "user32" ) ]
        internal static extern bool AnimateWindow( IntPtr hWnd, int dwTime, int dwFlags );

        [ DllImport( "Gdi32.dll", EntryPoint = "CreateRoundRectRgn" ) ]
        internal static extern IntPtr CreateRoundRectRgn( int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse,
            int nHeightEllipse );
    }
}