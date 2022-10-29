//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;

    public interface IChartSeriesModel
    {
        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        int Count { get; set; }

        /// <summary> Gets the empty. </summary>
        /// <param name = "xIndex" > The xIndex. </param>
        /// <returns> </returns>
        bool GetEmpty( int xIndex );

        /// <summary> Gets the x. </summary>
        /// <param name = "xIndex" > The xIndex. </param>
        /// <returns> </returns>
        double GetX( int xIndex );

        /// <summary> Gets the y. </summary>
        /// <param name = "xIndex" > The xIndex. </param>
        /// <returns> </returns>
        double GetY( int xIndex );

        /// <summary> Occurs when [changed]. </summary>
        event ListChangedEventHandler Changed;
    }
}