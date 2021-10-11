// <copyright file="TestValidator.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WARP.XrmSolutionValidator.Core.Models;

    /// <summary>
    /// A test implementation of a Validator.
    /// </summary>
    public class TestValidator : IValidator
    {
        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            var result = new ValidationResult
            {
                ValidationCompletedSuccessfully = true,
            };

            result.AddFeedback(FeedbackLevel.Error, "This is a test error.");
            result.AddFeedback(FeedbackLevel.Warning, "A test warning.");

            return result;
        }
    }
}
