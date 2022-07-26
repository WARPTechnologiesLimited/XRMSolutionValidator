// <copyright file="EntityValidatorTests.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Tests.Validators
{
    using Xunit;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.Validators;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    public class EntityValidatorTests
    {
        [Fact]
        public void WithOnlyInternalEntities_Succeeds()
        {
            var sit = new EntityValidator();
            var sln = SetupSolution(2);
            
            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Entity, schemaName = "warp_entity1", behavior = "0"};
            sln.Solution.SolutionManifest[0].RootComponents[1] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Entity, schemaName = "warp_entity2", behavior = "2" };

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }

        [Fact]
        public void WithExternalAllAssetsEntities_Warning()
        {
            var sit = new EntityValidator();
            var sln = SetupSolution(2);

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Entity, schemaName = "ext_entity1", behavior = "0" };
            sln.Solution.SolutionManifest[0].RootComponents[1] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Entity, schemaName = "ext_entity2", behavior = "0" };

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(2, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }

        [Fact]
        public void WithExternalAssetEntities_Succeeds()
        {
            var sit = new EntityValidator();
            var sln = SetupSolution(2);

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Entity, schemaName = "ext_entity1", behavior = "2" };
            sln.Solution.SolutionManifest[0].RootComponents[1] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Entity, schemaName = "ext_entity2", behavior = "2" };

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }

        [Fact]
        public void WithNoEntities_Succeeds()
        {
            var sit = new EntityValidator();
            var sln = SetupSolution(0);

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }

        [Fact]
        public void PrefixSimilarToInternalPrefix_Warning()
        {
            var sit = new EntityValidator();
            var sln = SetupSolution(2);

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Entity, schemaName = "warpish_entity1", behavior = "0" };
            sln.Solution.SolutionManifest[0].RootComponents[1] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Entity, schemaName = "warpish_entity2", behavior = "0" };

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(2, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
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
                            Publisher = new[]
                            {
                                new ImportExportXmlSolutionManifestPublisher()
                                {
                                    CustomizationPrefix = "warp"
                                }
                            }
                        }
                    }
                }
            };
            return sln;
        }
    }
}
