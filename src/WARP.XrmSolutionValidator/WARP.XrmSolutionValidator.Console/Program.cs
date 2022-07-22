// <copyright file="Program.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Console
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using WARP.XrmSolutionValidator.Core;
    using WARP.XrmSolutionValidator.Core.Validators;

    /// <summary>
    /// A console application to execute the Solution validation.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry method for the console application.
        /// </summary>
        /// <param name="args">The passed command line arguments.</param>
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please provide the following arguments in order:");
                Console.WriteLine("1 - Path to the unpacked solution to run validation against.");
                Console.WriteLine("2 - Path to the web resources source code directory.");
                return;
            }

            Console.WriteLine("Starting Validation...");

            var v = new ValidationEngine(new List<IValidator>
            {
                new WorkflowScope(),
                new WorkflowIntegrity(),
                new AssemblyReferences(),
                new SavedQueriesExists(),
                new WebResourceIntegrity(),
            });

            v.LoadSolution(new DirectoryInfo(args[0]), new DirectoryInfo(args[1]));

            var result = v.Validate();

            Console.WriteLine($"Validation completed with output of: {result.ValidationCompletedSuccessfully}{Environment.NewLine}{Environment.NewLine}LIST:");

            foreach (var item in result.FeedbackItems)
            {
                Console.WriteLine($"{item.Level}: {item.Message}");
            }

            Console.WriteLine($"{Environment.NewLine}SUMMARY{Environment.NewLine}Total Errors: {result.TotalErrors}{Environment.NewLine}Total Warnings: {result.TotalWarnings}");

            Console.ReadKey();
        }
    }
}