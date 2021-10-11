// <copyright file="ValidationResult.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class for containing the results of a Validation.
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        public ValidationResult()
        {
            this.FeedbackItems = new List<FeedbackItem>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the validation completed successfully.
        /// </summary>
        public bool ValidationCompletedSuccessfully { get; set; }

        /// <summary>
        /// Gets the feedback items associated with validation.
        /// </summary>
        public List<FeedbackItem> FeedbackItems { get; }

        /// <summary>
        /// Gets the total number of errors in the list of feedback.
        /// </summary>
        public int TotalErrors
        {
            get
            {
                return this.FeedbackItems?.Count(f => f.Level == FeedbackLevel.Error) ?? 0;
            }
        }

        /// <summary>
        /// Gets the total number of errors in the list of feedback.
        /// </summary>
        public int TotalWarnings
        {
            get
            {
                return this.FeedbackItems?.Count(f => f.Level == FeedbackLevel.Warning) ?? 0;
            }
        }

        /// <summary>
        /// Adds a feedback item to the collection.
        /// </summary>
        /// <param name="level">The feedback level.</param>
        /// <param name="message">The message to go with feedback.</param>
        public void AddFeedback(FeedbackLevel level, string message)
        {
            this.FeedbackItems.Add(new FeedbackItem { Level = level, Message = message });
        }
    }
}
