// <copyright file="Entity.additions.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.XrmModels
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// Hand-coded additions to the generated Entity partial class.
    /// </summary>
    public partial class Entity
    {
        /// <summary>
        /// Gets or sets details of the SavedQueries linked to an Entity. I.e. data loaded from the saved queries XML files.
        /// </summary>
        [XmlIgnore]
        public List<savedqueries> SavedQueryDetails { get; set; } = new List<savedqueries>();
    }
}
