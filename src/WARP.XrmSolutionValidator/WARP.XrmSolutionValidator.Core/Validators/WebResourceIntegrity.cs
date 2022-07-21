// <copyright file="WebResourceIntegrity.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System.Linq;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    /// <summary>
    /// A validator which checks integrity of the parts of the Solution that related to web resources, including files and root components.
    /// </summary>
    public class WebResourceIntegrity : IValidator
    {
        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            const string suffix = ".data.xml";
            var result = new ValidationResult { ValidationCompletedSuccessfully = true };

            var lowercaseXmlNames = solution.WebResourceXmlNames.Select(w => w.ToLower().Replace('\\', '/')).ToList();
            var lowercaseSuffixedRootSchemaNames = solution.GetRootComponentSchemaNames(XrmRootComponentTypes.WebResource).Select(sn => $"{sn.ToLower()}{suffix}");
            foreach (var lowercaseXmlName in lowercaseXmlNames.Where(x => !lowercaseSuffixedRootSchemaNames.Contains(x)))
            {
                result.AddFeedback(FeedbackLevel.Error, $"Web Resource detected that is missing from the Solution.xml file '{lowercaseXmlName}'");
            }

            foreach (var lowercaseRootSchemaName in lowercaseSuffixedRootSchemaNames.Where(rsn =>
                         !lowercaseXmlNames.Contains(rsn)))
            {
                result.AddFeedback(FeedbackLevel.Error, $"Web Resource file missing '{lowercaseRootSchemaName}'");
            }

            return result;
        }
    }
}
