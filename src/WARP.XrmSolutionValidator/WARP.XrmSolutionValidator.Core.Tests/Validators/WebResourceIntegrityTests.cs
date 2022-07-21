// <copyright file="WebResourceIntegrityTests.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Tests.Validators
{
    using System.Collections.Generic;

    using Xunit;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.Validators;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    public class WebResourceIntegrityTests
    {
        [Fact]
        public void MatchingFilesSucceeds()
        {
            var sit = new WebResourceIntegrity();
            var sln = SetupSolution(2);

            sln.WebResourceXmlNames = new List<string>() { "file1.data.xml", "file2.data.xml" };
            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.WebResource, schemaName = "file1" };
            sln.Solution.SolutionManifest[0].RootComponents[1] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.WebResource, schemaName = "file2" };

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }
        [Fact]
        public void MatchingFilesWithBackslashSucceeds()
        {
            var sit = new WebResourceIntegrity();
            var sln = SetupSolution(2);

            sln.WebResourceXmlNames = new List<string>() { "prefix_\\images\\file1.svg.data.xml", "file2.svg.data.xml" };
            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.WebResource, schemaName = "prefix_/images/file1.svg" };
            sln.Solution.SolutionManifest[0].RootComponents[1] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.WebResource, schemaName = "file2.svg" };

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }

        [Fact]
        public void MissingFileCausesError()
        {
            var sit = new WebResourceIntegrity();
            var sln = SetupSolution(1);

            sln.WebResourceXmlNames = new List<string>();
            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.WebResource, schemaName = "file2"};

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(1, result.TotalErrors);
        }

        [Fact]
        public void MissingRootComponentCausesError()
        {
            var sit = new WebResourceIntegrity();
            var sln = SetupSolution(1);

            sln.WebResourceXmlNames = new List<string>() { "file1.data.xml", "file2.data.xml" };
            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.WebResource, schemaName = "file2" };

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(1, result.TotalErrors);
        }

        private static XrmSolutionWrapper SetupSolution(int numRootComponents)
        {
            var sln = new XrmSolutionWrapper(null)
            {
                Solution = new ImportExportXml
                {
                    SolutionManifest = new []
                    {
                        new ImportExportXmlSolutionManifest
                            {RootComponents = new ImportExportXmlSolutionManifestRootComponentsRootComponent[numRootComponents]}
                    }
                }
            };
            return sln;
        }
    }
}
