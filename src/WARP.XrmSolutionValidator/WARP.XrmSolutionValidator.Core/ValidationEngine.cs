// <copyright file="ValidationEngine.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.Validators;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    /// <summary>
    /// The engine for performing a validation pass.
    /// </summary>
    public class ValidationEngine
    {
        private readonly IEnumerable<IValidator> validators;

        private XrmSolutionWrapper solution;

        private bool solutionLoaded;

        /// <summary>
        /// Initialises a new instance of the <see cref="ValidationEngine"/> class.
        /// </summary>
        /// <param name="validators">The validators to be used with this engine.</param>
        public ValidationEngine(IEnumerable<IValidator> validators)
        {
            this.validators = validators;
        }

        /// <summary>
        /// Loads the required data from the Solution for validation.
        /// </summary>
        /// <param name="solutionRoot">The root directory of the Solution.</param>
        /// <returns>True if load was successful.</returns>
        public bool LoadSolution(DirectoryInfo solutionRoot)
        {
            if (solutionRoot == null || !solutionRoot.Exists)
            {
                throw new ArgumentException("Solution directory does not exist or is incorrectly set.");
            }

            this.solution = new XrmSolutionWrapper(solutionRoot)
            {
                Solution = Helpers.XmlLoader<XrmModels.ImportExportXml>.LoadXml(Path.Combine(solutionRoot.FullName, "Other", "Solution.xml")),
            };

            // Load Entity XML
            foreach (var entityDirectory in solutionRoot.GetDirectories("*Entities")[0].GetDirectories())
            {
                var entityFile = entityDirectory.GetFiles("Entity.xml").FirstOrDefault();
                if (entityFile != null)
                {
                    var entity = Helpers.XmlLoader<Entity>.LoadXml(entityFile.FullName);

                    foreach (var savedQueriesDirectory in entityDirectory.GetDirectories("SavedQueries"))
                    {
                        foreach (var file in savedQueriesDirectory.GetFiles("{*}.xml"))
                        {
                            entity.SavedQueryDetails.Add(Helpers.XmlLoader<savedqueries>.LoadXml(file.FullName));
                        }
                    }

                    this.solution.Entities.Add(entity);
                }
            }

            var relationshipsDir = new DirectoryInfo(Path.Combine(solutionRoot.FullName, "Other", "Relationships"));

            if (relationshipsDir.Exists)
            {
                // Load Entity Relationships XML
                foreach (var file in relationshipsDir.GetFiles().Where(f => f.Extension == ".xml"))
                {
                    this.solution.EntityRelationships.Add(Helpers.XmlLoader<EntityRelationships>.LoadXml(file.FullName));
                }
            }

            var optionSetsDir = new DirectoryInfo(Path.Combine(solutionRoot.FullName, "OptionSets"));

            if (optionSetsDir.Exists)
            {
                // Load OptionSet XML
                foreach (var file in optionSetsDir.GetFiles().Where(f => f.Extension == ".xml"))
                {
                    this.solution.OptionSets.Add(Helpers.XmlLoader<optionset>.LoadXml(file.FullName));
                }
            }

            var pluginsDir = new DirectoryInfo(Path.Combine(solutionRoot.FullName, "PluginAssemblies"));

            if (pluginsDir.Exists)
            {
                // Load Plugin Assembly XML
                foreach (var entityDirectory in pluginsDir.GetDirectories())
                {
                    foreach (var file in entityDirectory.GetFiles().Where(f => f.Extension == ".xml"))
                    {
                        this.solution.PluginAssemblies.Add(Helpers.XmlLoader<PluginAssembly>.LoadXml(file.FullName));
                    }
                }
            }

            var sdkMessagesDir = new DirectoryInfo(Path.Combine(solutionRoot.FullName, "SdkMessageProcessingSteps"));

            if (sdkMessagesDir.Exists)
            {
                // Load SDK message processing step XML
                foreach (var file in sdkMessagesDir.GetFiles().Where(f => f.Extension == ".xml"))
                {
                    this.solution.SdkMessageProcessingSteps.Add(Helpers.XmlLoader<SdkMessageProcessingStep>.LoadXml(file.FullName));
                }
            }

            var workflowsDir = new DirectoryInfo(Path.Combine(solutionRoot.FullName, "Workflows"));

            if (workflowsDir.Exists)
            {
                // Load Workflow XML
                foreach (var file in workflowsDir.GetFiles().Where(f => f.Extension == ".xml"))
                {
                    this.solution.Workflows.Add(Helpers.XmlLoader<Workflow>.LoadXml(file.FullName));
                }

                // Load Workflow XAML Names
                foreach (var file in workflowsDir.GetFiles().Where(f => f.Extension == ".xaml"))
                {
                    // Trim the 
                    this.solution.WorkflowXamlNames.Add(file.Name);
                }
            }

            var webResourceDir = new DirectoryInfo(Path.Combine(solutionRoot.FullName, "WebResources"));
            if (webResourceDir.Exists)
            {
                // Load Web Resource XML file names
                foreach (var fileName in webResourceDir.GetFiles("*.data.xml", new EnumerationOptions() { RecurseSubdirectories = true }))
                {
                    this.solution.WebResourceXmlNames.Add(Path.GetRelativePath(webResourceDir.FullName, fileName.FullName));
                }
            }

            this.solutionLoaded = true;
            return true;
        }

        /// <summary>
        /// Runs the validation process, the Solution must be loaded first.
        /// </summary>
        /// <returns>The result of the validation.</returns>
        public ValidationResult Validate()
        {
            try
            {
                if (!this.solutionLoaded)
                {
                    throw new InvalidOperationException("A solution has not yet been loaded. Please load one using the LoadSolution method.");
                }

                var result = new ValidationResult { ValidationCompletedSuccessfully = true };

                foreach (var validator in this.validators)
                {
                    try
                    {
                        result.FeedbackItems.AddRange(validator.Validate(this.solution).FeedbackItems);
                    }
                    catch
                    {
                        result.ValidationCompletedSuccessfully = false;
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
