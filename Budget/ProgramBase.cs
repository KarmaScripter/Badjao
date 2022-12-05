// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public abstract class ProgramBase : DataUnit, IProgram
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public virtual int ID { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public virtual DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public virtual IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Gets the definition.
        /// </summary>
        /// <value>
        /// The definition.
        /// </value>
        public virtual string Definition { get; set; }

        /// <summary>
        /// Gets the laws.
        /// </summary>
        /// <value>
        /// The laws.
        /// </value>
        public virtual string Laws { get; set; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public virtual string Title { get; set; }

        /// <summary>
        /// Gets the narrative.
        /// </summary>
        /// <value>
        /// The narrative.
        /// </value>
        public virtual string Narrative { get; set; }

        /// <summary>
        /// Gets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public virtual string ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public virtual string ProgramAreaName { get; set; }
    }
}