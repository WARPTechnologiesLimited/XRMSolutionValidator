// <copyright file="IdHelpers.cs" company="WARP Technologies Limited">
// Released by WARP for use by the CRM development community.
// </copyright>

namespace WARP.XrmSolutionValidator.Core.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class IdHelpers
    {
        public static bool IdEquals(this string value, string compareValue)
        {
            value = value?.TrimStart('{');
            compareValue = compareValue?.TrimStart('{');
            value = value?.TrimEnd('}');
            compareValue = compareValue?.TrimEnd('}');

            return value == compareValue;
        }
    }
}
