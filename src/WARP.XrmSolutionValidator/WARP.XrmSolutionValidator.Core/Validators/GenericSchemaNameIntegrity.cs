// <copyright file="GenericSchemaNameIntegrity.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>
namespace WARP.XrmSolutionValidator.Core.Validators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    /// <summary>
    /// A validator which checks the integrity of items with solution.xml root components that contain a "schemaName".
    /// </summary>
    public class GenericSchemaNameIntegrity : IValidator
    {
        private readonly string rootComponentType;
        private readonly string solutionComponentListPropertyName;
        private readonly string fileSuffix;

        /// <summary>
        /// Initialises a new instance of the <see cref="GenericSchemaNameIntegrity"/> class.
        /// </summary>
        /// <param name="rootComponentType">The root component type to operate on, e.g. "9".</param>
        /// <param name="solutionComponentListPropertyName">The name of the property in the deserialized XML object which contains the list of components. E.g. "OptionSets" because the list property is XmlSolutionWrapper.OptionSets.</param>
        /// <param name="fileSuffix">Any suffix which is added to the file names compared to the schema name, e.g. ".data.xml".</param>
        public GenericSchemaNameIntegrity(string rootComponentType, string solutionComponentListPropertyName, string fileSuffix = "")
        {
            this.rootComponentType = rootComponentType;
            this.solutionComponentListPropertyName = solutionComponentListPropertyName;
            this.fileSuffix = fileSuffix;
        }

        /// <inheritdoc />
        public ValidationResult Validate(XrmSolutionWrapper solution)
        {
            var result = new ValidationResult { ValidationCompletedSuccessfully = true };

            var rootComponentSchemaNames = solution
                .GetRootComponentSchemaNames(this.rootComponentType)
                .Select(sn => $"{sn.ToLower()}{this.fileSuffix}");

            // Use reflection to get the list of solution components.
            var listProperty = solution.GetType().GetProperty(this.solutionComponentListPropertyName);
            if (listProperty == null)
            {
                throw new InvalidOperationException($"XrmSolutionWrapper does not contain a property called '{this.solutionComponentListPropertyName}'");
            }

            var xmlEntries = (IEnumerable)listProperty.GetValue(solution);
            var solutionComponentNames = new List<string>();
            foreach (var xmlEntry in xmlEntries)
            {
                var entryType = xmlEntry.GetType();

                string componentName;
                if (entryType == typeof(string))
                {
                    componentName = (string)xmlEntry;
                }
                else
                {
                    var nameProperty = entryType.GetProperty("Name");
                    if (nameProperty == null)
                    {
                        throw new InvalidOperationException($"{entryType.Name} does not contain a property called '{this.solutionComponentListPropertyName}'");
                    }

                    componentName = (string)nameProperty.GetValue(xmlEntry);
                }

                var slashReplacedComponentName = componentName.Replace('\\', '/');
                solutionComponentNames.Add(slashReplacedComponentName.ToLowerInvariant());
            }

            foreach (var name in solutionComponentNames.Where(scn => !rootComponentSchemaNames.Any(r => r == scn)))
            {
                result.AddFeedback(FeedbackLevel.Error, $"{XrmRootComponentTypes.GetDisplayName(this.rootComponentType)} detected that is missing from the solution.xml file: '{name}'");
            }

            foreach (var name in rootComponentSchemaNames.Where(r => !solutionComponentNames.Exists(scn => scn == r)))
            {
                result.AddFeedback(FeedbackLevel.Error, $"{XrmRootComponentTypes.GetDisplayName(this.rootComponentType)} file missing: '{name}'");
            }

            return result;
        }
    }
}
