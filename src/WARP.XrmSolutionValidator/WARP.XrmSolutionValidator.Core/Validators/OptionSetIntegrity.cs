// <copyright file="OptionSetIntegrity.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    /// <summary>
    /// A validator which checks integrity of the parts of the Solution that related to option sets, including files and root components.
    /// </summary>
    public class OptionSetIntegrity : IValidator
    {
        private readonly GenericSchemaNameIntegrity internalValidator = new GenericSchemaNameIntegrity(XrmRootComponentTypes.OptionSet, "OptionSets");

        /// <inheritdoc />
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            return this.internalValidator.Validate(solution);
        }
    }
}
