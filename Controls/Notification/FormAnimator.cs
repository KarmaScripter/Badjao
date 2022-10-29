// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <summary>
    /// Animates a form when it is shown, hidden or closed
    /// </summary>
    /// <remarks>
    /// MDI child forms do not support the Fade
    /// method and only support other methods while
    /// being displayed for the first time and when closing
    /// </remarks>
    public sealed class FormAnimator
    {
        /// <summary>
        /// Hide the form
        /// </summary>
        private const int AwHide = 0x10000;

        /// <summary>
        /// Activate the form
        /// </summary>
        private const int AwActivate = 0x20000;

        /// <summary>
        /// The number of milliseconds over which
        /// the animation occurs if no value is specified
        /// </summary>
        private const int DefaultDuration = 250;

        /// <summary>
        /// Gets or sets the animation method used to show and hide the form
        /// </summary>
        /// <value>
        /// The animation method used to show and hide the form
        /// </value>
        /// <remarks>
        /// <b>Roll</b> is used by default if no method is specified
        /// </remarks>
        public AnimationMethod Method { get; set; }

        /// <summary>
        /// Gets or Sets the direction in which the animation is performed
        /// </summary>
        /// <value>
        /// The direction in which the animation is performed
        /// </value>
        /// <remarks>
        /// The direction is only applicable to the <b>Roll</b> and <b>Slide</b> methods
        /// </remarks>
        public AnimationDirection Direction { get; set; }

        /// <summary>
        /// Gets or Sets the number of milliseconds over which the animation is played
        /// </summary>
        /// <value>
        /// The number of milliseconds over which the animation is played
        /// </value>
        public int Duration { get; set; }

        /// <summary>
        /// Gets the form to be animated
        /// </summary>
        /// <value>
        /// The form to be animated
        /// </value>
        public Form Form { get; set; }

        /// <summary>
        /// Creates a new <
        /// b>FormAnimator</b>
        /// object for the specified form
        /// </summary>
        /// <param name="form">
        /// The form to be animated
        /// </param>
        /// <remarks>
        /// No animation will be used unless the <b>Method</b>
        /// and/or <b>Direction</b> properties are set independently.
        /// The <b>Duration</b> is set to quarter of a second by default.
        /// </remarks>
        public FormAnimator( Form form )
        {
            Form = form;
            Form.Load += Form_Load;
            Form.VisibleChanged += Form_VisibleChanged;
            Form.Closing += Form_Closing;
            Duration = DefaultDuration;
        }

        /// <summary>
        /// Creates a new <b>FormAnimator</b> object for the specified
        /// form using the specified method over the specified duration
        /// </summary>
        /// <param name="form">
        /// The form to be animated
        /// </param>
        /// <param name="method">
        /// The animation method used to show and hide the form
        /// </param>
        /// <param name="duration">
        /// The number of milliseconds over which the animation is played
        /// </param>
        /// <remarks>
        /// No animation will be used for the
        /// <b>Roll</b> or
        /// <b>Slide</b> methods unless the
        /// <b>Direction</b> property is set independently
        /// </remarks>
        public FormAnimator( Form form, AnimationMethod method, int duration )
            : this( form )
        {
            Method = method;
            Duration = duration;
        }

        /// <summary>
        /// Creates a new <b>FormAnimator</b> object for the specified form
        /// using the specified method in the specified direction over the specified duration
        /// </summary>
        /// <param name="form">
        /// The form to be animated
        /// </param>
        /// <param name="method">
        /// The animation method used to show and hide the form
        /// </param>
        /// <param name="direction">
        /// The direction in which to animate the form
        /// </param>
        /// <param name="duration">
        /// The number of milliseconds over which the animation is played
        /// </param>
        /// <remarks>
        /// The <i>direction</i> argument will have no effect if the <b>Center</b> or <b>Fade</b> method is
        /// specified
        /// </remarks>
        public FormAnimator( Form form, AnimationMethod method, AnimationDirection direction,
            int duration )
            : this( form, method, duration )
        {
            Direction = direction;
        }

        /// <summary>
        /// The methods of animation available.
        /// </summary>
        public enum AnimationMethod
        {
            /// <summary>
            /// Rolls out from edge when
            /// showing and into edge when hiding
            /// </summary>
            /// <remarks>
            /// This is the default animation
            /// method and requires a direction
            /// </remarks>
            Roll = 0x0,

            /// <summary>
            /// Expands out from center when
            /// showing and collapses into center when hiding
            /// </summary>
            Center = 0x10,

            /// <summary>
            /// Slides out from edge when showing
            /// and slides into edge when hiding
            /// </summary>
            /// <remarks>
            /// Requires a direction
            /// </remarks>
            Slide = 0x40000,

            /// <summary>
            /// Fades from transparent to opaque when
            /// showing and from opaque to transparent when hiding
            /// </summary>
            Fade = 0x80000
        }

        /// <summary>
        /// The directions in which the Roll and Slide animations can be shown
        /// </summary>
        /// <remarks>
        /// Horizontal and vertical directions can be
        /// combined to create diagonal animations
        /// </remarks>
        [ Flags ]
        public enum AnimationDirection
        {
            /// <summary>
            /// From left to right
            /// </summary>
            Right = 0x1,

            /// <summary>
            /// From right to left
            /// </summary>
            Left = 0x2,

            /// <summary>
            /// From top to bottom
            /// </summary>
            Down = 0x4,

            /// <summary>
            /// From bottom to top
            /// </summary>
            Up = 0x8
        }

        /// <summary>
        /// Animates the form automatically when it is loaded
        /// </summary>
        private void Form_Load( object sender, EventArgs e )
        {
            if( Form.MdiParent == null
               || Method != AnimationMethod.Fade )
            {
                NativeMethods.AnimateWindow( Form.Handle, Duration,
                    AwActivate | (int)Method | (int)Direction );
            }
        }

        /// <summary>
        /// Animates the form automatically when it is shown or hidden
        /// </summary>
        private void Form_VisibleChanged( object sender, EventArgs e )
        {
            if( Form.MdiParent == null )
            {
                var flags = (int)Method | (int)Direction;

                if( Form.Visible )
                {
                    flags |= AwActivate;
                }
                else
                {
                    flags |= AwHide;
                }

                NativeMethods.AnimateWindow( Form.Handle, Duration, flags );
            }
        }

        /// <summary>
        /// Animates the form automatically when it closes
        /// </summary>
        private void Form_Closing( object sender, CancelEventArgs e )
        {
            if( !e.Cancel )
            {
                if( Form.MdiParent == null
                   || Method != AnimationMethod.Fade )
                {
                    NativeMethods.AnimateWindow( Form.Handle, Duration,
                        AwHide | (int)Method | (int)Direction );
                }
            }
        }
    }
}