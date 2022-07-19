// <copyright file="XrmSolutionWrapper.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

using WARP.XrmSolutionValidator.Core.Helpers;

namespace WARP.XrmSolutionValidator.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Text;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    /// <summary>
    /// Class to contain all data that the validators will require when checking Solutions.
    /// </summary>
    public class XrmSolutionWrapper
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="XrmSolutionWrapper"/> class.
        /// </summary>
        /// <param name="solutionRoot">The directory where the Solution files are held.</param>
        public XrmSolutionWrapper(DirectoryInfo solutionRoot)
        {
            this.SolutionRoot = solutionRoot;

            this.Entities = new List<Entity>();
            this.EntityRelationshps = new List<EntityRelationships>();
            this.OptionSets = new List<optionset>();
            this.PluginAssemblies= new List<PluginAssembly>();
            this.SdkMessageProcessingSteps = new List<SdkMessageProcessingStep>();
            this.Workflows = new List<Workflow>();
            this.WorkflowXamlNames = new List<string>();
        }

        /// <summary>
        /// Gets the root directory for the Solution files.
        /// </summary>
        public DirectoryInfo SolutionRoot { get; }

        /// <summary>
        /// Gets or sets the content of the main Solution.xml file.
        /// </summary>
        public ImportExportXml Solution { get; set; }

        /// <summary>
        /// Gets or sets the entities contained in the Solution files.
        /// </summary>
        public List<Entity> Entities { get; set; }

        /// <summary>
        /// Gets or sets the entity relationships contained in the Solution files.
        /// </summary>
        public List<EntityRelationships> EntityRelationshps { get; set; }

        /// <summary>
        /// Gets or sets the option sets contained in the Solution files.
        /// </summary>
        public List<optionset> OptionSets { get; set; }

        /// <summary>
        /// Gets or sets the plugin assemblies contained in the Solution files.
        /// </summary>
        public List<PluginAssembly> PluginAssemblies { get; set; }

        /// <summary>
        /// Gets or sets the SDK message processing steps contained in the Solution files.
        /// </summary>
        public List<SdkMessageProcessingStep> SdkMessageProcessingSteps { get; set; }

        /// <summary>
        /// Gets or sets the Workflows contained in the Solution files.
        /// </summary>
        public List<Workflow> Workflows { get; set; }

        /// <summary>
        /// Gets or sets the Workflow XAML file names contained in the Solution files.
        /// </summary>
        public List<string> WorkflowXamlNames { get; set; }

        /// <summary>
        /// Check for the specified root components in the solution.
        /// </summary>
        /// <param name="type">The type of component, ideally provided by WARP.XrmSolutionValidator.Core.XrmModels.XrmRootComponentTypes.</param>
        /// <param name="id">The ID to check for.</param>
        /// <returns>True if a matching root component is found.</returns>
        public bool RootComponentExists(string type, string id)
        {
            return this.Solution.SolutionManifest.SelectMany(m =>
                m.RootComponents?.Where(rc => rc.type == type && rc.id.IdEquals(id))).Any();
        }

        /// <summary>
        /// Get the IDs for for the specified type of root component in the solution.
        /// </summary>
        /// <param name="type">The type of component, ideally provided by WARP.XrmSolutionValidator.Core.XrmModels.XrmRootComponentTypes.</param>
        /// <returns>Enumerable of root components.</returns>
        public IEnumerable<string> GetRootComponentIds(string type)
        {
            return this.Solution.SolutionManifest.SelectMany(m =>
                    m.RootComponents?.Where(rc => rc.type == type).Select(r => r.id.ToLower()));
        }
    }
}
