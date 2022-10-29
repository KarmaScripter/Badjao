//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    public class SplashControl : SplashBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashControl" /> class.
        /// </summary>
        /// <remarks>
        /// The default value for the
        /// <see cref="P:Syncfusion.Windows.Forms.Tools.SplashPanel.TimerInterval" />
        /// is set to
        /// The splash panel has animation turned and by default will appear in the
        /// middle of the screen.
        /// </remarks>
        public SplashControl( )
        {
            BackColor = Color.FromArgb( 15, 15, 15 );
            ForeColor = Color.White;
            Font = new Font( "Roboto", 9 );
            Size = new Size( 300, 150 );
            BorderStyle = Border3DStyle.Etched;
            BorderType = SplashBorderType.Border3D;

            BackgroundColor = new BrushInfo( GradientStyle.PathEllipse,
                Color.FromArgb( 15, 15, 15 ), Color.FromArgb( 45, 45, 45 ) );

            ShowAnimation = true;
            ShowAsTopMost = true;
            AnimationSpeed = 20;
            AnimationSteps = 3;
            AnimationDirection = AnimationDirection.Default;
            DesktopAlignment = SplashAlignment.Center;
            DiscreetLocation = new Point( 0, 0 );
            SuspendAutoCloseWhenMouseOver = false;
            TabIndex = 0;
            TimerInterval = 5000;
            CloseOnClick = true;
            MarqueePosition = MarqueePosition.BottomRight;
            MarqueeDirection = SplashPanelMarqueeDirection.RightToLeft;
            SlideStyle = SlideStyle.FadeIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplashControl"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public SplashControl( string message )
            : this( )
        {
            Text = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplashControl"/> class.
        /// </summary>
        /// <param name="toolTip">The tool tip.</param>

        // ReSharper disable once SuggestBaseTypeForParameter
        public SplashControl( MetroTip toolTip )
            : this( )
        {
            Text = toolTip?.TipText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplashControl"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="message">The message.</param>
        public SplashControl( Control control, string message )
            : this( )
        {
            Parent = control;
            Text = message;
        }

        /// <summary>
        /// Displays the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.SplashPanel" />
        /// Splash panel.
        /// </summary>
        public void ShowMessage( )
        {
            if( !string.IsNullOrEmpty( Text ) )
            {
                try
                {
                    ShowSplash( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}