// <copyright file="FeedbackItem.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Models
{
    /// <summary>
    /// A model to hold the data for each individual item of feedback.
    /// </summary>
    public class FeedbackItem
    {
        /// <summary>
        /// Gets or sets the message associated with the feedback.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the level of the feedback.
        /// </summary>
        public FeedbackLevel Level { get; set; }
    }
}
