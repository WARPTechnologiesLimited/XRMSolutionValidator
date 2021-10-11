// <copyright file="XmlLoader.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Helpers
{
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// Generic code for loading to and object from an XML file on the disk.
    /// </summary>
    /// <typeparam name="T">The type to deserialise as.</typeparam>
    public static class XmlLoader<T>
    {
        /// <summary>
        /// Loads an XML file and returns the data in the specified object.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>The populated data object.</returns>
        public static T LoadXml(string path)
        {
            var ser = new XmlSerializer(typeof(T));
            using var reader = XmlReader.Create(path);
            return (T)ser.Deserialize(reader);
        }
    }
}
