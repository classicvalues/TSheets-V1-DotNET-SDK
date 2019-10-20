﻿// *******************************************************************************
// <copyright file="CreateContextValidatorTests.cs" company="Intuit">
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

namespace Intuit.TSheets.Tests.Unit.Client.RequestFlow.PipelineElements
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Intuit.TSheets.Client.Core;
    using Intuit.TSheets.Client.RequestFlow.Contexts;
    using Intuit.TSheets.Client.RequestFlow.PipelineElements;
    using Intuit.TSheets.Model.Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CreateContextValidatorTests : UnitTestBase
    {
        private CreateContextValidator pipelineElement;

        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();
            this.pipelineElement = CreateContextValidator.Instance;
        }

        [TestMethod, TestCategory("Unit")]
        [ExpectedException(typeof(BadRequestException))]
        public async Task CreateContextValidator_ThrowsWhenInputIdsIsNull()
        {
            var context = new CreateContext<TestEntity>(EndpointName.Tests, null);

            await this.pipelineElement.ProcessAsync(context, MockLogger.Object, default)
                .ConfigureAwait(false);
        }

        [TestMethod, TestCategory("Unit")]
        [ExpectedException(typeof(BadRequestException))]
        public async Task CreateContextValidator_ThrowsWhenInputIdsIsEmpty()
        {
            var context = new CreateContext<TestEntity>(EndpointName.Tests, new List<TestEntity>());

            await this.pipelineElement.ProcessAsync(context, MockLogger.Object, default)
                .ConfigureAwait(false);
        }

    }

}
