// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public enum TriggerEvent
    {
        Delete,

        Update,

        Insert
    }

    /// <summary>
    /// 
    /// </summary>
    public enum TriggerType
    {
        After,

        Before
    }

    /// <summary>
    /// 
    /// </summary>
    public class TriggerSchema
    {
        /// <summary>
        /// The body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The event
        /// </summary>
        public TriggerEvent Event { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The table
        /// </summary>
        public string Table { get; set; }

        /// <summary>
        /// The type
        /// </summary>
        public TriggerType Type { get; set; }
    }
}