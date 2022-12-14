// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" )]
    public class BigTip : SuperToolTip
    {
        /// <summary>
        /// Gets or sets the tip text.
        /// </summary>
        /// <value>
        /// The tip text.
        /// </value>
        public virtual TextItem TipText { get; set; }

        /// <summary>
        /// Gets or sets the tip information.
        /// </summary>
        /// <value>
        /// The tip information.
        /// </value>
        public virtual ToolTipInfo TipInfo { get; set; }

        /// <summary>
        /// Gets or sets the tip item.
        /// </summary>
        /// <value>
        /// The tip item.
        /// </value>
        public virtual ToolTipInfo.ToolTipItem TipItem { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        public BigTip( )
        {
            // Basic Properties
            InitialDelay = 300;
            ToolTipDuration = 5;
            CanApplyTheme = true;
            VisualStyle = Appearance.Metro;
            CanOverrideStyle = true;
            UseFading = FadingType.System;

            // TipInfo Properties
            TipInfo = new ToolTipInfo( );
            TipInfo.BackColor = Color.FromArgb( 40, 40, 40 );
            TipInfo.BorderColor = Color.FromArgb( 0, 120, 212 );
            TipInfo.ForeColor = Color.LightSteelBlue;
            TipInfo.Separator = true;

            // Header Properties
            TipInfo.Header.Font = new Font( "Roboto", 14 );
            TipInfo.Header.ForeColor = Color.FromArgb( 0, 120, 212 );
            TipInfo.Header.TextAlign = ContentAlignment.MiddleCenter;
            TipInfo.Header.ImageAlign = ContentAlignment.TopLeft;
            TipInfo.Header.ImageScalingSize = new Size( 10, 14 );

            // Body Properties
            TipInfo.Body.Font = new Font( "Roboto", 10 );
            TipInfo.Body.ForeColor = Color.LightGray;
            TipInfo.Body.TextAlign = ContentAlignment.MiddleCenter;

            // Footer Properties
            TipInfo.Footer.Font = new Font( "Roboto", 8 );
            TipInfo.Footer.ForeColor = Color.FromArgb( 65, 65, 65 );
            TipInfo.Footer.TextAlign = ContentAlignment.BottomLeft;
        }

        public BigTip( Control control, string text, string title = "" )
            : this( )
        {
        }
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="SmallTip"/> class.
        /// </summary>
        /// <param name="toolItem">The toolItem.</param>
        public BigTip( ToolStripItem toolItem )
            : this( )
        {
        }

        /// <summary>
        /// Sets the header text.
        /// </summary>
        /// <param name="bodyText">The body text.</param>
        public virtual void SetHeaderText( string bodyText )
        {
            try
            {
                if( !string.IsNullOrEmpty( bodyText ) )
                {
                    TipInfo.Body.Text = bodyText;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the body text.
        /// </summary>
        /// <param name="bodyText">The body text.</param>
        public virtual void SetBodyText( string bodyText )
        {
            try
            {
                if( !string.IsNullOrEmpty( bodyText ) )
                {
                    TipInfo.Body.Text = bodyText;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the header tool information properties.
        /// </summary>
        public virtual void SetFooterText( string footerText )
        {
            try
            {
                if( !string.IsNullOrEmpty( footerText ) )
                {
                    TipInfo.Body.Text = footerText;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}