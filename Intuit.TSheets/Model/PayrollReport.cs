﻿// *******************************************************************************
// <copyright file="PayrollReport.cs" company="Intuit">
// Copyright (c) 2019 Intuit
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
// *******************************************************************************

namespace Intuit.TSheets.Model
{
    using System.Collections.Generic;
    using Intuit.TSheets.Client.Serialization.Attributes;
    using Newtonsoft.Json;

    /// <summary>
    /// PayrollReport, a payroll report associated with a time frame, with filters to narrow down the results.
    /// </summary>
    [DataEntity]
    [JsonObject]
    public class PayrollReport
    {
        /// <summary>
        /// Gets the report.
        /// </summary>
        /// <remarks>
        /// Totals are indexed by unique user id.
        /// </remarks>
        [JsonProperty("payroll_report")]
        public IReadOnlyDictionary<string, PayrollReportItem> Report { get; internal set; }
    }
}
