// <copyright file="WorkflowIntegrityTests.cs" company="WARP Technologies Limited">
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

    public class WorkflowIntegrityTests
    {
        [Fact]
        public void WorkflowWithMissingXamlFileCreatesError()
        {
            var sit = new WorkflowIntegrity();

            var wfGuid = "{1512ceff-0194-ec11-b400-6045bd0eee86}";

            var sln = SetupSolution();

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    {type = XrmRootComponentTypes.Workflow, id = wfGuid};

            sln.Workflows.Add(new Workflow { XamlFileName = "somefile.xaml", WorkflowId = wfGuid });

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(1, result.TotalErrors);
        }

        [Fact]
        public void WorkflowWithAllComponentsDoesntError()
        {
            var sit = new WorkflowIntegrity();

            var wfGuid = "{1512ceff-0194-ec11-b400-6045bd0eee86}";
            var wfXamlFilename = "MyProcess-1512ceff-0194-ec11-b400-6045bd0eee86.xaml";

            var sln = SetupSolution();

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Workflow, id = wfGuid };

            sln.Workflows.Add(new Workflow { XamlFileName = $"\\Workflows\\{wfXamlFilename}", WorkflowId = wfGuid });
            sln.WorkflowXamlNames.Add(wfXamlFilename);

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }

        [Fact]
        public void WorkflowWithMissingXmlCreatesError()
        {
            var sit = new WorkflowIntegrity();

            var wfGuid = "{1512ceff-0194-ec11-b400-6045bd0eee86}";
            var wfXamlFilename = "MyProcess-1512ceff-0194-ec11-b400-6045bd0eee86.xaml";

            var sln = SetupSolution();

            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.Workflow, id = wfGuid };

            sln.WorkflowXamlNames.Add(wfXamlFilename);
            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(1, result.TotalErrors);
        }

        [Fact]
        public void WorkflowMissingFromSolutionCreatesError()
        {
            var sit = new WorkflowIntegrity();

            var wfGuid = "{1512ceff-0194-ec11-b400-6045bd0eee86}";
            var wfXamlFilename = "MyProcess-1512ceff-0194-ec11-b400-6045bd0eee86.xaml";

            var sln = SetupSolution();

            // Create the wrong type of root component to fail the test.
            sln.Solution.SolutionManifest[0].RootComponents[0] =
                new ImportExportXmlSolutionManifestRootComponentsRootComponent
                    { type = XrmRootComponentTypes.PluginType, id = wfGuid };

            sln.Workflows.Add(new Workflow { XamlFileName = $"\\Workflows\\{wfXamlFilename}", WorkflowId = wfGuid });

            sln.WorkflowXamlNames.Add(wfXamlFilename);
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
