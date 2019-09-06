﻿// *******************************************************************************
// <copyright file="Program.cs" company="Intuit">
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

namespace Intuit.TSheets.Examples
{
    using System;
    using Intuit.TSheets.Client.Core;

    /// <summary>
    /// An example custom auth provider.  For real-world applications you'll need to use
    /// OAuth2 flow (see https://tsheetsteam.github.io/api_docs/#authentication), rather
    /// than the static tokens that are intended for development purposes (used through-
    /// out this example code).
    /// </summary>
    internal class CustomAuthProvider : IOAuth2
    {
        public string GetAccessToken()
        {
            // Implement your token access logic here.
            // Retrieve from a database, for example.
            throw new NotImplementedException();
        }
    }
}
