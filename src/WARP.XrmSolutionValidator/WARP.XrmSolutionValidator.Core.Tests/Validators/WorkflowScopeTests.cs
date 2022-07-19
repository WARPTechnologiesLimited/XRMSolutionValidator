// <copyright file="WorkflowScopeTests.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Tests.Validators
{
    using System;
    using Xunit;
    using WARP.XrmSolutionValidator.Core;

    using System.IO;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.Validators;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    public class WorkflowScopeTests
    {
        [Fact]
        public void SolutionWith1Scope1ReturnsOnly1Warning()
        {
            var sit = new WorkflowScope();

            var sln = new XrmSolutionWrapper(null);

            sln.Workflows.Add(new Workflow { Scope = "1" });
            sln.Workflows.Add(new Workflow { Scope = "2" });
            sln.Workflows.Add(new Workflow { Scope = "0" });
            sln.Workflows.Add(new Workflow { Scope = "-1" });
            sln.Workflows.Add(new Workflow { Scope = "" });

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(1, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }

        [Fact]
        public void SolutionWith0Scope1ReturnsNoWarningOrErrors()
        {
            var sit = new WorkflowScope();

            var sln = new XrmSolutionWrapper(null);

            sln.Workflows.Add(new Workflow { Scope = "2" });
            sln.Workflows.Add(new Workflow { Scope = "0" });
            sln.Workflows.Add(new Workflow { Scope = "-1" });
            sln.Workflows.Add(new Workflow { Scope = "" });

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }
    }
}
