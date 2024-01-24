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
    public sealed class FeatureFlagEnvironmentContextTarget
    {
        /// <summary>
        /// The context kind on which the flag should target in this environment. User (`user`) targets should be specified as `targets` attribute blocks.
        /// </summary>
        public readonly string ContextKind;
        /// <summary>
        /// List of `user` strings to target.
        /// </summary>
        public readonly ImmutableArray<string> Values;
        /// <summary>
        /// The index of the variation to serve if a user target value is matched.
        /// </summary>
        public readonly int Variation;

        [OutputConstructor]
        private FeatureFlagEnvironmentContextTarget(
            string contextKind,

            ImmutableArray<string> values,

            int variation)
        {
            ContextKind = contextKind;
            Values = values;
            Variation = variation;
        }
    }
}
