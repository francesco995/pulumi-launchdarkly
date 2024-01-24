// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly
{
    public static class GetTeamMembers
    {
        /// <summary>
        /// Provides a LaunchDarkly team members data source.
        /// 
        /// This data source allows you to retrieve team member information from your LaunchDarkly organization on multiple team members.
        /// </summary>
        public static Task<GetTeamMembersResult> InvokeAsync(GetTeamMembersArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTeamMembersResult>("launchdarkly:index/getTeamMembers:getTeamMembers", args ?? new GetTeamMembersArgs(), options.WithDefaults());

        /// <summary>
        /// Provides a LaunchDarkly team members data source.
        /// 
        /// This data source allows you to retrieve team member information from your LaunchDarkly organization on multiple team members.
        /// </summary>
        public static Output<GetTeamMembersResult> Invoke(GetTeamMembersInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTeamMembersResult>("launchdarkly:index/getTeamMembers:getTeamMembers", args ?? new GetTeamMembersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTeamMembersArgs : global::Pulumi.InvokeArgs
    {
        [Input("emails", required: true)]
        private List<string>? _emails;

        /// <summary>
        /// An array of unique email addresses associated with the team members.
        /// </summary>
        public List<string> Emails
        {
            get => _emails ?? (_emails = new List<string>());
            set => _emails = value;
        }

        /// <summary>
        /// A boolean to determine whether to ignore members that weren't found.
        /// </summary>
        [Input("ignoreMissing")]
        public bool? IgnoreMissing { get; set; }

        public GetTeamMembersArgs()
        {
        }
        public static new GetTeamMembersArgs Empty => new GetTeamMembersArgs();
    }

    public sealed class GetTeamMembersInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("emails", required: true)]
        private InputList<string>? _emails;

        /// <summary>
        /// An array of unique email addresses associated with the team members.
        /// </summary>
        public InputList<string> Emails
        {
            get => _emails ?? (_emails = new InputList<string>());
            set => _emails = value;
        }

        /// <summary>
        /// A boolean to determine whether to ignore members that weren't found.
        /// </summary>
        [Input("ignoreMissing")]
        public Input<bool>? IgnoreMissing { get; set; }

        public GetTeamMembersInvokeArgs()
        {
        }
        public static new GetTeamMembersInvokeArgs Empty => new GetTeamMembersInvokeArgs();
    }


    [OutputType]
    public sealed class GetTeamMembersResult
    {
        public readonly ImmutableArray<string> Emails;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool? IgnoreMissing;
        public readonly ImmutableArray<Outputs.GetTeamMembersTeamMemberResult> TeamMembers;

        [OutputConstructor]
        private GetTeamMembersResult(
            ImmutableArray<string> emails,

            string id,

            bool? ignoreMissing,

            ImmutableArray<Outputs.GetTeamMembersTeamMemberResult> teamMembers)
        {
            Emails = emails;
            Id = id;
            IgnoreMissing = ignoreMissing;
            TeamMembers = teamMembers;
        }
    }
}
