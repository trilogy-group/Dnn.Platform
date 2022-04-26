﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.Modules.TelerikRemovalLibrary
{
    using DotNetNuke.Instrumentation;

    /// <inheritdoc />
    internal class NullStep : StepBase, INullStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullStep"/> class.
        /// </summary>
        /// <param name="loggerSource">An instance of <see cref="ILoggerSource"/>.</param>
        public NullStep(ILoggerSource loggerSource)
            : base(loggerSource)
        {
        }

        /// <inheritdoc/>
        public override string Name => this.InternalName;

        /// <summary>
        /// Gets or sets the step's internal name.
        /// </summary>
        public string InternalName { get; set; }

        /// <inheritdoc/>
        protected override void ExecuteInternal()
        {
            this.Success = false;
            this.Notes = "Not yet implemented.";
        }
    }
}
