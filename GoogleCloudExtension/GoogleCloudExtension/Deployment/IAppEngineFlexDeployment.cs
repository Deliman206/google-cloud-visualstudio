﻿// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Threading.Tasks;

namespace GoogleCloudExtension.Deployment
{
    /// <summary>
    /// Service interface for deploying a project to App Engine Flexible Environment.
    /// </summary>
    public interface IAppEngineFlexDeployment
    {
        /// <summary>
        /// Publishes the ASP.NET Core project to App Engine Flex and reports progress to the UI.
        /// </summary>
        /// <param name="project">The project to deploy.</param>
        /// <param name="options">The <see cref="AppEngineFlexDeployment.DeploymentOptions"/> to use.</param>
        Task PublishProjectAsync(
            IParsedProject project,
            AppEngineFlexDeployment.DeploymentOptions options);
    }
}