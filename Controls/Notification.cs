// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using Syncfusion.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using static System.Drawing.Region;
    using static System.Windows.Forms.Screen;
    using static FormAnimator;
    using static NativeMethods;
    using Point = System.Drawing.Point;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class Notification : MetroForm
    {
        /// <summary>
        /// The current foreground window
        /// </summary>
        private IntPtr _currentForegroundWindow;

        /// <summary>
        /// The open notifications
        /// </summary>
        public static readonly List<Notification> OpenNotifications = new ( );

        /// <summary>
        /// Gets or sets a value indicating whether [allow focus].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow focus]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowFocus { get; set; }

        /// <summary>
        /// Gets the animator.
        /// </summary>
        /// <value>
        /// The animator.
        /// </value>
        public FormAnimator Animator { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        public Notification( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="body">The body.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animation">The animation.</param>
        /// <param name="direction">The direction.</param>
        public Notification( string title, string body, int duration = 2,
            AnimationMethod animation = AnimationMethod.Slide,
            AnimationDirection direction = AnimationDirection.Left )
            : this( )
        {
            InitializeComponent( );
            BackColor = Color.FromArgb( 10, 10, 10 );
            Load += OnLoad;
            Timer.Interval = duration * 1000;
            Title.Text = title;
            Message.Text = body;
            Animator = new FormAnimator( this, animation, direction, 500 );
            Region = FromHrgn( CreateRoundRectRgn( 0, 0, Width - 5, 
                Height - 5, 20, 20 ) );
            Activated += OnActivated;
            Shown += OnShown;
            FormClosed += OnClosed;
            Click += ( s, e ) => Close( );
            Message.Click += ( s, e ) => Close( );
            Title.Click += ( s, e ) => Close( );
            Timer.Tick += OnTimerTick;
        }

        /// <summary>
        /// Displays the control to the user.
        /// </summary>
        public new void Show( )
        {
            _currentForegroundWindow = GetForegroundWindow( );
            base.Show( );
        }

        /// <summary>
        /// Notifications the close.
        /// </summary>
        public void NotificationClose( )
        {
            Close( );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            Location = new Point( PrimaryScreen.WorkingArea.Width - Width,
                PrimaryScreen.WorkingArea.Height - Height );
            foreach( var _form in OpenNotifications )
            {
                _form.Top -= Height;
            }
            OpenNotifications.Add( this );
            Timer.Start( );
        }

        /// <summary>
        /// Called when [activated].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnActivated( object sender, EventArgs e )
        {
            if( !AllowFocus )
            {
                SetForegroundWindow( _currentForegroundWindow );
            }
        }

        /// <summary>
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnShown( object sender, EventArgs e )
        {
            AllowFocus = true;
            Animator.Duration = 1500;
            Animator.Direction = AnimationDirection.Down;
        }

        /// <summary>
        /// Called when [closed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void OnClosed( object sender, FormClosedEventArgs e )
        {
            foreach( var _openForm in OpenNotifications )
            {
                if( _openForm == this )
                {
                    break;
                }

                _openForm.Top += Height;
            }

            OpenNotifications.Remove( this );
        }

        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            Close( );
        }
    }
}