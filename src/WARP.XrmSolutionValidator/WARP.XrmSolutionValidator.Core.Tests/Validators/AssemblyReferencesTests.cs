// <copyright file="AssemblyReferencesTests.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Tests.Validators
{
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.Validators;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;

    public class AssemblyReferencesTests
    {
        [Fact]
        public void AssemblyWithCorrectReferencesDoesNotError()
        {
            var sit = new AssemblyReferences();

            var assemblyGuid = "{1512ceff-0194-ec11-b400-6045bd0eee86}";

            var sln = SetupSolution();

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.PluginAssembly, id = assemblyGuid };
            sln.PluginAssemblies.Add(new PluginAssembly { PluginAssemblyId = assemblyGuid });

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }

        [Fact]
        public void AssemblyWithMissingXmlFileCreatesError()
        {
            var sit = new AssemblyReferences();

            var assemblyGuid = "{1512ceff-0194-ec11-b400-6045bd0eee86}";

            var sln = SetupSolution();

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.PluginAssembly, id = assemblyGuid };
            
            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(1, result.TotalErrors);
        }

        [Fact]
        public void AssemblyWithMissingSolutionReferenceDoesNotError()
        {
            var sit = new AssemblyReferences();

            var assemblyGuid = "{1512ceff-0194-ec11-b400-6045bd0eee86}";

            var sln = SetupSolution();

            // Using incorrect type to fail test.
            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Workflow, id = assemblyGuid };

            sln.PluginAssemblies.Add(new PluginAssembly { PluginAssemblyId = assemblyGuid });

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(1, result.TotalErrors);
        }

        private static XrmSolutionWrapper SetupSolution()
        {
            var sln = new XrmSolutionWrapper(null)
            {
                Solution = new ImportExportXml
                {
                    SolutionManifest = new ImportExportXmlSolutionManifest[]
                    {
                        new ImportExportXmlSolutionManifest
                            {RootComponents = new ImportExportXmlSolutionManifestRootComponentsRootComponent[1]}
                    }
                }
            };
            return sln;
        }
    }
}
