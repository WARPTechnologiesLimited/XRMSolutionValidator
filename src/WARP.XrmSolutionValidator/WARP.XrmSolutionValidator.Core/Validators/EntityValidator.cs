// <copyright file="EntityValidator.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System.Linq;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    /// <summary>
    /// A validator which ensures that not external entities are included with 'all assets'.
    /// </summary>
    public class EntityValidator : IValidator
    {
        /// <summary>The entity 'behavior' value for 'All Assets'.</summary>
        private const string AllAssets = "0";

        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            var result = new ValidationResult { ValidationCompletedSuccessfully = true };

            var internalPrefix = $"{solution.Solution.SolutionManifest[0].Publisher[0].CustomizationPrefix}_";

            foreach (var entityRootComponent in solution.Solution.SolutionManifest[0].RootComponents
                         .Where(rc =>
                             rc.type == XrmRootComponentTypes.Entity && !rc.schemaName.StartsWith(internalPrefix) &&
                             rc.behavior == AllAssets))
            {
                result.AddFeedback(FeedbackLevel.Warning, $"Entity '{entityRootComponent.schemaName}' is not from the solution publisher and includes 'All Assets'.");
            }

            return result;
        }
    }
}