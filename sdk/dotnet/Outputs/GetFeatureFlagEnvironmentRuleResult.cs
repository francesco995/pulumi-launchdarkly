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
    public sealed class GetFeatureFlagEnvironmentRuleResult
    {
        public readonly string? BucketBy;
        public readonly ImmutableArray<Outputs.GetFeatureFlagEnvironmentRuleClauseResult> Clauses;
        public readonly string? Description;
        public readonly ImmutableArray<int> RolloutWeights;
        public readonly int? Variation;

        [OutputConstructor]
        private GetFeatureFlagEnvironmentRuleResult(
            string? bucketBy,

            ImmutableArray<Outputs.GetFeatureFlagEnvironmentRuleClauseResult> clauses,

            string? description,

            ImmutableArray<int> rolloutWeights,

            int? variation)
        {
            BucketBy = bucketBy;
            Clauses = clauses;
            Description = description;
            RolloutWeights = rolloutWeights;
            Variation = variation;
        }
    }
}
