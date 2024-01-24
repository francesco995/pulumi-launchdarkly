// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly.Inputs
{

    public sealed class ProjectEnvironmentApprovalSettingGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Set to `true` if changes can be applied as long as the `min_num_approvals` is met, regardless of whether any reviewers have declined a request. Defaults to `true`.
        /// </summary>
        [Input("canApplyDeclinedChanges")]
        public Input<bool>? CanApplyDeclinedChanges { get; set; }

        /// <summary>
        /// Set to `true` if requesters can approve or decline their own request. They may always comment. Defaults to `false`.
        /// </summary>
        [Input("canReviewOwnRequest")]
        public Input<bool>? CanReviewOwnRequest { get; set; }

        /// <summary>
        /// The number of approvals required before an approval request can be applied. This number must be between 1 and 5. Defaults to 1.
        /// </summary>
        [Input("minNumApprovals")]
        public Input<int>? MinNumApprovals { get; set; }

        /// <summary>
        /// Set to `true` for changes to flags in this environment to require approval. You may only set `required` to true if `required_approval_tags` is not set and vice versa. Defaults to `false`.
        /// </summary>
        [Input("required")]
        public Input<bool>? Required { get; set; }

        [Input("requiredApprovalTags")]
        private InputList<string>? _requiredApprovalTags;

        /// <summary>
        /// An array of tags used to specify which flags with those tags require approval. You may only set `required_approval_tags` if `required` is not set to `true` and vice versa.
        /// </summary>
        public InputList<string> RequiredApprovalTags
        {
            get => _requiredApprovalTags ?? (_requiredApprovalTags = new InputList<string>());
            set => _requiredApprovalTags = value;
        }

        [Input("serviceConfig")]
        private InputMap<object>? _serviceConfig;

        /// <summary>
        /// The configuration for the service associated with this approval. This is specific to each approval service. For a `service_kind` of `servicenow`, the following fields apply:
        /// </summary>
        public InputMap<object> ServiceConfig
        {
            get => _serviceConfig ?? (_serviceConfig = new InputMap<object>());
            set => _serviceConfig = value;
        }

        /// <summary>
        /// The kind of service associated with this approval. This determines which platform is used for requesting approval. Valid values are `servicenow`, `launchdarkly`.
        /// </summary>
        [Input("serviceKind")]
        public Input<string>? ServiceKind { get; set; }

        public ProjectEnvironmentApprovalSettingGetArgs()
        {
        }
        public static new ProjectEnvironmentApprovalSettingGetArgs Empty => new ProjectEnvironmentApprovalSettingGetArgs();
    }
}
