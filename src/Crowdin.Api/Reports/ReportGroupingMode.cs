﻿
using System.ComponentModel;
using JetBrains.Annotations;

namespace Crowdin.Api.Reports
{
    [PublicAPI]
    public enum ReportGroupingMode
    {
        [Description("user")]
        User,
            
        [Description("language")]
        Language
    }
}