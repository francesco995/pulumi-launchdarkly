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
    public sealed class FeatureFlagClientSideAvailability
    {
        /// <summary>
        /// Whether this flag is available to SDKs using the client-side ID.
        /// </summary>
        public readonly bool? UsingEnvironmentId;
        /// <summary>
        /// Whether this flag is available to SDKs using a mobile key.
        /// </summary>
        public readonly bool? UsingMobileKey;

        [OutputConstructor]
        private FeatureFlagClientSideAvailability(
            bool? usingEnvironmentId,

            bool? usingMobileKey)
        {
            UsingEnvironmentId = usingEnvironmentId;
            UsingMobileKey = usingMobileKey;
        }
    }
}