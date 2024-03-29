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
    public sealed class GetAuditLogSubscriptionStatementResult
    {
        public readonly ImmutableArray<string> Actions;
        public readonly string Effect;
        public readonly ImmutableArray<string> NotActions;
        public readonly ImmutableArray<string> NotResources;
        public readonly ImmutableArray<string> Resources;

        [OutputConstructor]
        private GetAuditLogSubscriptionStatementResult(
            ImmutableArray<string> actions,

            string effect,

            ImmutableArray<string> notActions,

            ImmutableArray<string> notResources,

            ImmutableArray<string> resources)
        {
            Actions = actions;
            Effect = effect;
            NotActions = notActions;
            NotResources = notResources;
            Resources = resources;
        }
    }
}
