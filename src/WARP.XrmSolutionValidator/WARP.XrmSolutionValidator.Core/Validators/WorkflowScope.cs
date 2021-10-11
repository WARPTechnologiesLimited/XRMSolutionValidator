// <copyright file="WorkflowScope.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WARP.XrmSolutionValidator.Core.Models;

    /// <summary>
    /// A validator that raises warnings if a Workflow has an undesirable scope.
    /// </summary>
    public class WorkflowScope : IValidator
    {
        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            var result = new ValidationResult { ValidationCompletedSuccessfully = true };

            foreach (var workflow in solution.Workflows.Where(w => w.Scope == "1"))
            {
                result.FeedbackItems.Add(new FeedbackItem { Level = FeedbackLevel.Warning, Message = $"Workflow '{workflow.Name}' has a scope of 1." });
            }

            return result;
        }
    }
}
