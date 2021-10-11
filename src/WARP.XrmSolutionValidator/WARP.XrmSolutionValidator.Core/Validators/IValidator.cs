// <copyright file="IValidator.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WARP.XrmSolutionValidator.Core.Models;

    /// <summary>
    /// This interface defines the interaction with Validators.
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution);
    }
}
