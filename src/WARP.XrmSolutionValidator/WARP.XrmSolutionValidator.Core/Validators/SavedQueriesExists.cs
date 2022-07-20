// <copyright file="SavedQueriesExists.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System.Linq;
    using WARP.XrmSolutionValidator.Core.Models;

    /// <summary>
    /// A validator that raises errors if an entity has saved queries files, but the SavedQueries element does not exist in Entity.xml.
    /// </summary>
    public class SavedQueriesExists : IValidator
    {
        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            var result = new ValidationResult { ValidationCompletedSuccessfully = true };

            foreach (var entity in solution.Entities.Where(e => e.SavedQueries == null && e.SavedQueryDetails.Any()))
            {
                result.FeedbackItems.Add(new FeedbackItem { Level = FeedbackLevel.Error, Message = $"Entity '{entity.Name[0].Value}' has {entity.SavedQueryDetails.Count} saved queries, but has no SavedQueries element in its Entity.xml." });
            }

            return result;
        }
    }
}
