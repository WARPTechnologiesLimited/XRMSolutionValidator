// <copyright file="AssemblyReferences.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

using System.Linq;
using WARP.XrmSolutionValidator.Core.Helpers;
using WARP.XrmSolutionValidator.Core.XrmModels;

namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System;
    using WARP.XrmSolutionValidator.Core.Models;

    /// <summary>
    /// Validator to ensure that required assemblies are referenced in the correct places.
    /// </summary>
    public class AssemblyReferences : IValidator
    {
        /// <summary>
        /// Executes the Validator.
        /// </summary>
        /// <param name="solution">The Solution to validate.</param>
        /// <returns>Feedback from the validation process.</returns>
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            var result = new ValidationResult { ValidationCompletedSuccessfully = true };

            // Check all assemblies exist in the solution.
            foreach (var plugin in solution.PluginAssemblies.Where(plugin => !solution.RootComponentExists(XrmRootComponentTypes.PluginAssembly, plugin.PluginAssemblyId)))
            {
                result.FeedbackItems.Add(new FeedbackItem { Level = FeedbackLevel.Error, Message = $"Plugin assembly '{plugin.FullName}' is not present in the solution." });
            }

            // Check all assemblies in the solution exist in the plugins directory.
            foreach (var rootComponent in solution.GetRootComponentIds(XrmRootComponentTypes.PluginAssembly).Where(id => solution.PluginAssemblies.All(p => !p.PluginAssemblyId.IdEquals(id))))
            {
                var name = solution.Solution.SolutionManifest
                    .SelectMany(m => m.RootComponents.Where(rc => rc.id.IdEquals(rootComponent))).FirstOrDefault();
                result.FeedbackItems.Add(new FeedbackItem { Level = FeedbackLevel.Error, Message = $"Plugin assembly '{name.schemaName}' is not present in the assemblies directory." });
            }

            return result;
        }
    }
}