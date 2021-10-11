// <copyright file="WorkflowIntegrity.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    /// <summary>
    /// A validator which checks integrity of the parts of the Solution that related to workflow, including files and root components.
    /// </summary>
    public class WorkflowIntegrity : IValidator
    {
        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            var result = new ValidationResult { ValidationCompletedSuccessfully = true };

            foreach (var wf in solution.Workflows.Where(w => !File.Exists(Path.Combine(solution.SolutionRoot.FullName, w.XamlFileName.Substring(1)))))
            {
                // Missing XAML file
                result.AddFeedback(FeedbackLevel.Error, $"Workflow XAML file missing '{wf.XamlFileName}'");
            }

            var workflowGuids =
                solution.Solution.SolutionManifest.SelectMany(m =>
                    m.RootComponents.Where(rc => rc.type == XrmRootComponentTypes.Workflow).Select(r => r.id.ToLower()));

            foreach (var workflow in solution.Workflows.Where(w => workflowGuids.All(g => string.Compare(w.WorkflowId, g, StringComparison.OrdinalIgnoreCase) != 0)))
            {
                // Workflow missing from solution XML
                result.AddFeedback(FeedbackLevel.Error, $"Workflow file detected that is missing from the Solution.xml file'{workflow.XamlFileName}'");
            }

            foreach (var wfGuid in workflowGuids.Where(g => solution.Workflows.All(w => w.WorkflowId != g)))
            {
                // Workflow file missing which is listed in solution XML
                result.AddFeedback(FeedbackLevel.Error, $"Workflow listed in Solution.xml with GUID {wfGuid} was not found in the workflow directory.");
            }

            return result;
        }
    }
}
