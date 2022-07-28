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
        private const string Suffix = ".data.xml";
        private readonly GenericSchemaNameIntegrity internalValidator = new GenericSchemaNameIntegrity(XrmRootComponentTypes.WebResource, "WebResourceXmlNames", Suffix);

        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            var lowercaseXmlNames = solution.WebResourceXmlNames.Select(w => w.ToLower().Replace('\\', '/')).ToList();
            var lowercaseRootSchemaNames = solution.GetRootComponentSchemaNames(XrmRootComponentTypes.WebResource).Select(sn => $"{sn.ToLower()}").ToList();
            var lowercaseSuffixedRootSchemaNames = lowercaseRootSchemaNames.Select(sn => $"{sn}{Suffix}");
            var lowercaseSourceCodeNames = solution.WebResourceSourceCodeFileNames.Select(w => w.ToLower().Replace('\\', '/')).ToList();

            // Remove any 'prefix_' from the first part of the directory if one exists.
            // e.g. "warp_/scripts/myForm.js" becomes "scripts/myForm.js"
            var lowerCasePrefixRemovedRootSchemaNames = lowercaseRootSchemaNames.Select(rsn =>
            {
                var splitDirectories = rsn.Split('/');
                return splitDirectories[0].EndsWith('_') ? string.Join('/', splitDirectories[1..]) : rsn;
            });

            var result = this.internalValidator.Validate(solution);

            foreach (var lowercaseRootSchemaName in lowerCasePrefixRemovedRootSchemaNames.Where(rsn =>
                         !lowercaseSourceCodeNames.Contains(rsn)))
            {
                result.AddFeedback(FeedbackLevel.Error, $"Web Resource source code file missing '{lowercaseRootSchemaName}'");
            }

            return result;
        }
    }
}
