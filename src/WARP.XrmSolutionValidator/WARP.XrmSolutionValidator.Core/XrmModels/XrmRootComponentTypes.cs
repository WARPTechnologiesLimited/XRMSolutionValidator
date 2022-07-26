// <copyright file="XrmRootComponentTypes.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.XrmModels
{
    /// <summary>
    /// Class containing the fixed Root Component values which are used in the main Solution.xml file.
    /// </summary>
    public static class XrmRootComponentTypes
    {
        /// <summary>
        /// Value used for entity records.
        /// </summary>
        public static readonly string Entity = "1";

        /// <summary>
        /// Value used for workflow records.
        /// </summary>
        public static readonly string Workflow = "29";

        /// <summary>
        /// Value used for web resource records.
        /// </summary>
        public static readonly string WebResource = "61";

        /// <summary>
        /// Value used for field permission records.
        /// </summary>
        public static readonly string FieldPermission = "71";

        /// <summary>
        /// Value used for plugin type records.
        /// </summary>
        public static readonly string PluginType = "90";

        /// <summary>
        /// Value used for plugin assembly records.
        /// </summary>
        public static readonly string PluginAssembly = "91";
    }
}
