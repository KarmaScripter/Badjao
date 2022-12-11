// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class SyncTipBase : SuperToolTip
    {
        /// <summary>
        /// Gets or sets the tip text.
        /// </summary>
        /// <value>
        /// The tip text.
        /// </value>
        public virtual TextItem TipText { get; set; } = new ( );

        /// <summary>
        /// Gets or sets the tip information.
        /// </summary>
        /// <value>
        /// The tip information.
        /// </value>
        public virtual ToolTipInfo TipInfo { get; set; } = new ( );

        /// <summary>
        /// Gets or sets the tip item.
        /// </summary>
        /// <value>
        /// The tip item.
        /// </value>
        public virtual ToolTipInfo.ToolTipItem TipItem { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="MetroTip"/> class.
        /// </summary>
        public SyncTipBase( )
        {
            SetCommonProperties(  );
            TipInfo.Header.Font = TipText.HeaderFont;
            TipInfo.Header.ForeColor = TipText.HeaderForeColor;
            TipInfo.Header.TextAlign = TipText.HeaderAlignment;
            TipInfo.Body.Font = TipText.BodyFont;
            TipInfo.Body.ForeColor = TipText.BodyForeColor;
            TipInfo.Body.TextAlign = TipText.BodyAlignment;
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="MetroTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public SyncTipBase( Control control )
        {
            SetCommonProperties(  );
            TipInfo.Header.Font = TipText.HeaderFont;
            TipInfo.Header.ForeColor = TipText.HeaderForeColor;
            TipInfo.Header.TextAlign = TipText.HeaderAlignment;
            TipInfo.Body.Font = TipText.BodyFont;
            TipInfo.Body.ForeColor = TipText.BodyForeColor;
            TipInfo.Body.TextAlign = TipText.BodyAlignment;
        }

        public SyncTipBase( TextItem tipText )
        {
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="MetroTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        /// <param name = "title" > </param>
        public SyncTipBase( Control control, string text, string title = "" )
            : this( )
        {
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="MetroTip"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="text">The text.</param>
        /// <param name = "title" > </param>
        public SyncTipBase( Component component, string text, string title = "" )
            : this( )
        {
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="MetroTip"/> class.
        /// </summary>
        /// <param name="toolItem">The toolItem.</param>
        public SyncTipBase( ToolStripItem toolItem )
            : this( )
        {
        }

        /// <summary>
        /// Sets the common tool information properties.
        /// </summary>
        public virtual void SetCommonProperties( )
        {
            try
            {
                InitialDelay = 500;
                CanApplyTheme = true;
                CanOverrideStyle = true;
                TipInfo.BackColor = Color.FromArgb( 40, 40, 40 );
                TipInfo.BorderColor = Color.FromArgb( 0, 120, 212 );
                TipInfo.ForeColor = Color.LightSteelBlue;
                TipInfo.Separator = true;
            }
            catch( Exception ex )
            {
                Fail( ex  );
            }
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
        /// Sets the body tool information properties.
        /// </summary>
        public virtual void SetBodyProperties( )
        {
            try
            {
                TipInfo.Body.Font = TipText.BodyFont;
                TipInfo.Body.ForeColor = TipText.BodyForeColor;
                TipInfo.Body.TextAlign = TipText.BodyAlignment;

                TipInfo.Body.Text = !string.IsNullOrEmpty( TipText.BodyText )
                    ? TipText.BodyText
                    : string.Empty;
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
        /// Sets the footer tool information properties.
        /// </summary>
        public virtual void SetFooterProperties( )
        {
            try
            {
                TipInfo.Footer.Font = TipText.FooterFont;
                TipInfo.Footer.ForeColor = TipText.FooterForeColor;
                TipInfo.Footer.TextAlign = TipText.FooterAlignment;

                TipInfo.Footer.Text = !string.IsNullOrEmpty( TipText.FooterText )
                    ? TipText.FooterText
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the header tool information properties.
        /// </summary>
        protected void SetHeaderToolInfoProperties( )
        {
            try
            {
                TipInfo.Header.Font = TipText.HeaderFont;
                TipInfo.Header.ForeColor = TipText.HeaderForeColor;
                TipInfo.Header.TextAlign = TipText.HeaderAlignment;

                TipInfo.Header.Text = !string.IsNullOrEmpty( TipText.HeaderText )
                    ? TipText.HeaderText
                    : string.Empty;
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
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}