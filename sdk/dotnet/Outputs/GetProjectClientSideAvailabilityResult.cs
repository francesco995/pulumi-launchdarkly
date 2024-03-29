// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly.Outputs
{

    [OutputType]
    public sealed class GetProjectClientSideAvailabilityResult
    {
        /// <summary>
        /// When set to true, the flags in this project are available to SDKs using the client-side ID by default.
        /// </summary>
        public readonly bool? UsingEnvironmentId;
        /// <summary>
        /// When set to true, the flags in this project are available to SDKs using a mobile key by default.
        /// </summary>
        public readonly bool? UsingMobileKey;

        [OutputConstructor]
        private GetProjectClientSideAvailabilityResult(
            bool? usingEnvironmentId,

            bool? usingMobileKey)
        {
            UsingEnvironmentId = usingEnvironmentId;
            UsingMobileKey = usingMobileKey;
        }
    }
}
