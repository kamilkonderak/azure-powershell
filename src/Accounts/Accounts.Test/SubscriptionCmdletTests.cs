﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Profile.Test
{
    public class SubscriptionCmdletTests : AccountsTestRunner
    {
        public SubscriptionCmdletTests(ITestOutputHelper output) 
            : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void AllParameterSetsSucceed()
        {
            TestRunner.RunTestScript("Test-GetSubscriptionsEndToEnd");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void SetAzureRmContextWorks()
        {
            TestRunner.RunTestScript("Test-SetAzureRmContextEndToEnd");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void PipingWithRmContextWorks()
        {
            TestRunner.RunTestScript("Test-PipingWithContext");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void SetAzureRmContextWithoutSubscription()
        {
            TestRunner.RunTestScript("Test-SetAzureRmContextWithoutSubscription");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void GetSubscriptionsWithTags()
        {
            TestRunner.RunTestScript("Test-GetSubscriptionsWithTags");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void GetSubscriptionsAfterContextRenameAndSet()
        {
            TestRunner.RunTestScript("Test-GetSubscriptionsAfterContextRenameAndSet");
        }
    }
}
