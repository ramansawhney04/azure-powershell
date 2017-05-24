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

using System;
using System.Linq;
using System.Threading;
using System.Management.Automation;
using Microsoft.AzureStack.AzureConsistentStorage;
using Microsoft.AzureStack.AzureConsistentStorage.Models;

namespace Microsoft.AzureStack.AzureConsistentStorage.Commands
{
    /// <summary>
    /// SYNTAX
    /// Stop-ACSContainerMigration  [-SubscriptionId] {string} [-Token] {string} [-AdminUri] {Uri} [-ResourceGroupName] {string} 
    ///                  [-FarmName] {string} [-ShareName] {string} -Jobid {string} [{CommonParameters}] 
    /// </summary>
    [Cmdlet(VerbsLifecycle.Stop, Nouns.AdminContainerMigration)]
    [Alias("Stop-ACSContainerMigration")]
    public sealed class StopContainerMigration : AdminCmdletDefaultFarm
    {
        /// <summary>
        /// Storage Account Name
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true )]
        public string JobId { get; set; }


        protected override void Execute()
        {
            var response = this.Client.Shares.SetMigrateContainerOperationStatus(this.ResourceGroupName, this.FarmName, this.JobId);
            this.WriteObject(response, true);
        }
    }
}
