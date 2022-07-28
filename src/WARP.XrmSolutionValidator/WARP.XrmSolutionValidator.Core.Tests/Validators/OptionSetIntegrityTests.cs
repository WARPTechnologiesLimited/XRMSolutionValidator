// <copyright file="OptionSetIntegrityTests.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

using System.Collections.Generic;

namespace WARP.XrmSolutionValidator.Core.Tests.Validators
{
    using Xunit;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.Validators;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    public class OptionSetIntegrityTests
    {
        [Fact]
        public void MissingRootComponent_Error()
        {
            var sit = new OptionSetIntegrity();
            var sln = SetupSolution(1);
            
            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.OptionSet, schemaName = "warp_option1", behavior = "0"};

            sln.OptionSets = new List<optionset>
            {
                new optionset() { Name = "warp_option1" },
                new optionset() { Name = "warp_option2" },
            };

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(1, result.TotalErrors);
        }
        [Fact]
        public void MissingSolutionComponent_Error()
        {
            var sit = new OptionSetIntegrity();
            var sln = SetupSolution(2);

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.OptionSet, schemaName = "warp_option1", behavior = "0" };
            sln.Solution.SolutionManifest[0].RootComponents[1] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.OptionSet, schemaName = "warp_option2", behavior = "0" };

            sln.OptionSets = new List<optionset>
            {
                new optionset() { Name = "warp_option1" },
            };

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
                        {
                            RootComponents = new ImportExportXmlSolutionManifestRootComponentsRootComponent[numRootComponents],
                        }
                    }
                }
            };
            return sln;
        }
    }
}
