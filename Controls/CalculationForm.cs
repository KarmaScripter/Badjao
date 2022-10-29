// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public partial class CalculationForm : MetroForm
    {
        public CalculationForm( )
        {
            InitializeComponent( );
            Calculator.BorderStyle = Border3DStyle.Adjust;
            Calculator.ValueCalculated += OnCalculationValueChanged;
        }

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