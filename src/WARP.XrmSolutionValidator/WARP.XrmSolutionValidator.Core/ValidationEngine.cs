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

            // Load Workflow XML
            foreach (var file in solutionRoot.GetDirectories("*Workflows")?[0].GetFiles().Where(f => f.Extension == ".xml"))
            {
                this.solution.Workflows.Add(Helpers.XmlLoader<Workflow>.LoadXml(file.FullName));
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
