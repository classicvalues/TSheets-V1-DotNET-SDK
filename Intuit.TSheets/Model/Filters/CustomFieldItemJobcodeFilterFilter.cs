﻿// *******************************************************************************
// <copyright file="CustomFieldItemJobcodeFilterFilter.cs" company="Intuit">
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

namespace Intuit.TSheets.Model.Filters
{
    using System;
    using Intuit.TSheets.Client.Serialization.Converters;
    using Newtonsoft.Json;

    /// <summary>
    /// Filter for narrowing down the results of a call to retrieve <see cref="Model.CustomFieldItemJobcodeFilter"/> entities.
    /// </summary>
    [JsonObject]
    public class CustomFieldItemJobcodeFilterFilter : EntityFilter
    {
        /// <summary>
        /// Gets or sets the value to filter results to only those with given jobcode id.
        /// </summary>
        [JsonProperty("jobcode_id")]
        public int? JobcodeId { get; set; }

        /// <summary>
        /// Gets or sets the date/time for which only results modified before it will be returned.
        /// </summary>
        [JsonConverter(typeof(DateTimeFormatConverter))]
        [JsonProperty("modified_before")]
        public DateTimeOffset? ModifiedBefore { get; set; }

        /// <summary>
        /// Gets or sets the date/time for which only results modified after it will be returned.
        /// </summary>
        [JsonConverter(typeof(DateTimeFormatConverter))]
        [JsonProperty("modified_since")]
        public DateTimeOffset? ModifiedSince { get; set; }
    }
}
