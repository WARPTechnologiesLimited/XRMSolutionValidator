// <copyright file="SavedQueriesExistsTests.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Tests.Validators
{
    using System.Collections.Generic;

    using Xunit;
    using WARP.XrmSolutionValidator.Core.Models;
    using WARP.XrmSolutionValidator.Core.Validators;
    using WARP.XrmSolutionValidator.Core.XrmModels;

    public class SavedQueriesExistsTests
    {
        [Fact]
        public void EntityWithMissingSavedQueriesElementCausesError()
        {
            var sit = new SavedQueriesExists();
            var sln = new XrmSolutionWrapper(null);

            sln.Entities.Add(new Entity()
            {
                SavedQueries = null,
                SavedQueryDetails = new List<savedqueries> { new savedqueries() },
            });

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(1, result.TotalErrors);
        }

        [Fact]
        public void EntityWithSavedQueriesElementPasses()
        {
            var sit = new SavedQueriesExists();
            var sln = new XrmSolutionWrapper(null);

            sln.Entities.Add(new Entity()
            {
                SavedQueries = string.Empty,
                SavedQueryDetails = new List<savedqueries> { new savedqueries() },
            });

            var result = sit.Validate(sln);

            Assert.True(result.ValidationCompletedSuccessfully);
            Assert.Equal(0, result.TotalWarnings);
            Assert.Equal(0, result.TotalErrors);
        }
    }
}
