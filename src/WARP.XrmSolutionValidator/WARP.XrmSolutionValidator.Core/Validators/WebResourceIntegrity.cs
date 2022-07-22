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
            var lowercaseRootSchemaNames = solution.GetRootComponentSchemaNames(XrmRootComponentTypes.WebResource).Select(sn => $"{sn.ToLower()}").ToList();
            var lowercaseSuffixedRootSchemaNames = lowercaseRootSchemaNames.Select(sn => $"{sn}{suffix}");
            var lowercaseSourceCodeNames = solution.WebResourceSourceCodeFileNames.Select(w => w.ToLower().Replace('\\', '/')).ToList();

            // Remove any 'prefix_' from the first part of the directory if one exists.
            // e.g. "warp_/scripts/myForm.js" becomes "scripts/myForm.js"
            var lowerCasePrefixRemovedRootSchemaNames = lowercaseRootSchemaNames.Select(rsn =>
            {
                var splitDirectories = rsn.Split('/');
                return splitDirectories[0].EndsWith('_') ? string.Join('/', splitDirectories[1..]) : rsn;
            });

            foreach (var lowercaseXmlName in lowercaseXmlNames.Where(x => !lowercaseSuffixedRootSchemaNames.Contains(x)))
            {
                result.AddFeedback(FeedbackLevel.Error, $"Web Resource detected that is missing from the Solution.xml file '{lowercaseXmlName}'");
            }

            foreach (var lowercaseRootSchemaName in lowercaseSuffixedRootSchemaNames.Where(rsn =>
                         !lowercaseXmlNames.Contains(rsn)))
            {
                result.AddFeedback(FeedbackLevel.Error, $"Web Resource file missing '{lowercaseRootSchemaName}'");
            }

            foreach (var lowercaseRootSchemaName in lowerCasePrefixRemovedRootSchemaNames.Where(rsn =>
                         !lowercaseSourceCodeNames.Contains(rsn)))
            {
                result.AddFeedback(FeedbackLevel.Error, $"Web Resource source code file missing '{lowercaseRootSchemaName}'");
            }

            return result;
        }
    }
}
