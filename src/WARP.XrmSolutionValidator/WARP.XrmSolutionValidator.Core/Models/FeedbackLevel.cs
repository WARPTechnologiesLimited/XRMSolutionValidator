// <copyright file="FeedbackLevel.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Models
{
    /// <summary>
    /// The levels of feedback that are available from a validation.
    /// </summary>
    public enum FeedbackLevel
    {
        /// <summary>
        /// Warning - items that will not prevent a deploy but could still cause issues.
        /// </summary>
        Warning,

        /// <summary>
        /// Error - items that will prevent the deploy of the Solution.
        /// </summary>
        Error,
    }
}
