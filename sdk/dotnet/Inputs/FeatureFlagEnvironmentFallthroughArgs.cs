// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly.Inputs
{

    public sealed class FeatureFlagEnvironmentFallthroughArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Group percentage rollout by a custom attribute. This argument is only valid if rollout_weights is also specified.
        /// </summary>
        [Input("bucketBy")]
        public Input<string>? BucketBy { get; set; }

        /// <summary>
        /// The context kind associated with the specified rollout. This argument is only valid if rollout_weights is also specified. If omitted, defaults to `user`.
        /// </summary>
        [Input("contextKind")]
        public Input<string>? ContextKind { get; set; }

        [Input("rolloutWeights")]
        private InputList<int>? _rolloutWeights;

        /// <summary>
        /// List of integer percentage rollout weights (in thousandths of a percent) to apply to each variation if the rule clauses evaluates to `true`. The sum of the `rollout_weights` must equal 100000 and the number of rollout weights specified in the array must match the number of flag variations. You must specify either `variation` or `rollout_weights`.
        /// </summary>
        public InputList<int> RolloutWeights
        {
            get => _rolloutWeights ?? (_rolloutWeights = new InputList<int>());
            set => _rolloutWeights = value;
        }

        /// <summary>
        /// The default integer variation index to serve if no `prerequisites`, `target`, or `rules` apply. You must specify either `variation` or `rollout_weights`.
        /// </summary>
        [Input("variation")]
        public Input<int>? Variation { get; set; }

        public FeatureFlagEnvironmentFallthroughArgs()
        {
        }
        public static new FeatureFlagEnvironmentFallthroughArgs Empty => new FeatureFlagEnvironmentFallthroughArgs();
    }
}
