// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class CalculationForm : MetroForm
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CalculationForm"/> class.
        /// </summary>
        public CalculationForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Font = new Font( "Roboto", 9 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Size = new Size( 420, 480 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionFont = new Font( "Roboto", 11  );
            CaptionButtonColor = Color.FromArgb( 65, 65, 65 );
            CaptionButtonHoverColor = Color.Red;
            MinimizeBox = false;
            MaximizeBox = false;

            // Calculator Configuration
            Calculator.Font = new Font( "Roboto", 10 );
            Calculator.Dock = DockStyle.Bottom;
            Calculator.BorderStyle = Border3DStyle.Adjust;
            Calculator.HorizontalSpacing = 10;
            Calculator.VerticalSpacing = 10;
            Calculator.UseVerticalAndHorizontalSpacing = true;
            Calculator.ShowDisplayArea = false;
            Calculator.ValueCalculated += OnCalculationValueChanged;

            // Label Configuration
            ValueLabel.Font = new Font( "Roboto", 14 );
            ValueLabel.Dock = DockStyle.Top;
            ValueLabel.BackColor = Color.Transparent;
            ValueLabel.ForeColor = Color.White;
            ValueLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Event Wiring
            Load += OnLoad;
        }

        /// <summary>
        /// Called when [calculation value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="CalculatorValueCalculatedEventArgs"/>
        /// instance containing the event data.</param>
        public void OnCalculationValueChanged( object sender, CalculatorValueCalculatedEventArgs e )
        {
            if( sender != null )
            {
                try
                {
                    ValueLabel.Text = Calculator.Value.ToString( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        public void OnLoad( object sender, EventArgs e )
        {
            Calculator.BorderStyle = Border3DStyle.Adjust;
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}