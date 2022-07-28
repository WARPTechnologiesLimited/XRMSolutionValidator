// <copyright file="XrmRootComponentTypes.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.XrmModels
{
    using System.Collections.Generic;

    /// <summary>
    /// Class containing the fixed Root Component values which are used in the main Solution.xml file.
    /// </summary>
    public static class XrmRootComponentTypes
    {
        /// <summary>
        /// Contains DisplayNames for each root component type.
        /// </summary>
        private static readonly Dictionary<string, string> DisplayNames = new Dictionary<string, string>()
        {
            { "1", "Entity" },
            { "9", "Option Set" },
            { "29", "Workflow" },
            { "61", "Web Resource" },
            { "71", "Field Permission" },
            { "90", "Plugin Type" },
            { "91", "Plugin Assembly" },
        };

        /// <summary>
        /// Gets the display name for a given root component type.
        /// </summary>
        /// <param name="key">The root component type (e.g. "29").</param>
        /// <returns>The display name of the root component type.</returns>
        public static string GetDisplayName(string key)
        {
            return DisplayNames[key];
        }

        /// <summary>
        /// Value used for entity records.
        /// </summary>
#pragma warning disable SA1201 // Elements should appear in the correct order. Disabled so the DisplayNames dictionary is 'in your face' and doesn't get forgotten when adding new entries.
        public static readonly string Entity = "1";
#pragma warning restore SA1201 // Elements should appear in the correct order

        /// <summary>
        /// Value used for option set records.
        /// </summary>
        public static readonly string OptionSet = "9";

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
