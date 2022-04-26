﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.Modules.TelerikRemovalLibrary
{
    using System;
    using System.Data;

    using DotNetNuke.Instrumentation;

    /// <inheritdoc/>
    internal class ExecuteSqlStep : StepBase, IExecuteSqlStep
    {
        private readonly IDataProvider dataProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteSqlStep"/> class.
        /// </summary>
        /// <param name="loggerSource">An instance of <see cref="ILoggerSource"/>.</param>
        /// <param name="dataProvider">An instance of <see cref="IDataProvider"/>.</param>
        public ExecuteSqlStep(ILoggerSource loggerSource, IDataProvider dataProvider)
            : base(loggerSource)
        {
            this.dataProvider = dataProvider ??
                throw new ArgumentNullException(nameof(dataProvider));
        }

        /// <inheritdoc/>
        [Required]
        public string CommandText { get; set; }

        /// <inheritdoc/>
        public string InternalName { get; set; }

        /// <inheritdoc/>
        public override string Name => this.InternalName;

        /// <inheritdoc/>
        public IDataReader Result { get; private set; }

        /// <inheritdoc/>
        protected override void ExecuteInternal()
        {
            this.Result = this.dataProvider.ExecuteSQL(this.CommandText);
            this.Success = true;
        }
    }
}
