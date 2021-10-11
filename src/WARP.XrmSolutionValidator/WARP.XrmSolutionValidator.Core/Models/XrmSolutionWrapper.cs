// <copyright file="XrmSolutionWrapper.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Models
{
    using System;
    using System.Collections.Generic;
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

            this.Workflows = new List<Workflow>();
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
        /// Gets or sets the Workflows contained in the Solution files.
        /// </summary>
        public List<Workflow> Workflows { get; set; }
    }
}
