// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly
{
    /// <summary>
    /// Provides a LaunchDarkly team member resource.
    /// 
    /// This resource allows you to create and manage team members within your LaunchDarkly organization.
    /// 
    /// &gt; **Note:** You can only manage team members with "admin" level personal access tokens. To learn more, read [Managing Teams](https://docs.launchdarkly.com/home/teams/managing).
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Launchdarkly = Pulumi.Launchdarkly;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var example = new Launchdarkly.TeamMember("example", new()
    ///     {
    ///         Email = "example.user@example.com",
    ///         FirstName = "John",
    ///         LastName = "Smith",
    ///         Role = "writer",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// LaunchDarkly team members can be imported using the team member's 24 character ID, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import launchdarkly:index/teamMember:TeamMember example 5f05565b48be0b441fb63020
    /// ```
    /// </summary>
    [LaunchdarklyResourceType("launchdarkly:index/teamMember:TeamMember")]
    public partial class TeamMember : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The list of custom roles keys associated with the team member. Custom roles are only available to customers on enterprise plans. To learn more about enterprise plans, contact sales@launchdarkly.com.
        /// 
        /// &gt; **Note:** each `launchdarkly.TeamMember` must have either a `role` or `custom_roles` argument.
        /// </summary>
        [Output("customRoles")]
        public Output<ImmutableArray<string>> CustomRoles { get; private set; } = null!;

        /// <summary>
        /// The unique email address associated with the team member. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Output("email")]
        public Output<string> Email { get; private set; } = null!;

        /// <summary>
        /// The team member's given name. Please note that, once created, this cannot be updated except by the team member themself.
        /// </summary>
        [Output("firstName")]
        public Output<string?> FirstName { get; private set; } = null!;

        /// <summary>
        /// The team member's family name. Please note that, once created, this cannot be updated except by the team member themself.
        /// </summary>
        [Output("lastName")]
        public Output<string?> LastName { get; private set; } = null!;

        /// <summary>
        /// The role associated with team member. Supported roles are `reader`, `writer`, `no_access`, or `admin`. If you don't specify a role, `reader` is assigned by default.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;


        /// <summary>
        /// Create a TeamMember resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TeamMember(string name, TeamMemberArgs args, CustomResourceOptions? options = null)
            : base("launchdarkly:index/teamMember:TeamMember", name, args ?? new TeamMemberArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TeamMember(string name, Input<string> id, TeamMemberState? state = null, CustomResourceOptions? options = null)
            : base("launchdarkly:index/teamMember:TeamMember", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/francesco995/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TeamMember resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TeamMember Get(string name, Input<string> id, TeamMemberState? state = null, CustomResourceOptions? options = null)
        {
            return new TeamMember(name, id, state, options);
        }
    }

    public sealed class TeamMemberArgs : global::Pulumi.ResourceArgs
    {
        [Input("customRoles")]
        private InputList<string>? _customRoles;

        /// <summary>
        /// The list of custom roles keys associated with the team member. Custom roles are only available to customers on enterprise plans. To learn more about enterprise plans, contact sales@launchdarkly.com.
        /// 
        /// &gt; **Note:** each `launchdarkly.TeamMember` must have either a `role` or `custom_roles` argument.
        /// </summary>
        public InputList<string> CustomRoles
        {
            get => _customRoles ?? (_customRoles = new InputList<string>());
            set => _customRoles = value;
        }

        /// <summary>
        /// The unique email address associated with the team member. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        /// <summary>
        /// The team member's given name. Please note that, once created, this cannot be updated except by the team member themself.
        /// </summary>
        [Input("firstName")]
        public Input<string>? FirstName { get; set; }

        /// <summary>
        /// The team member's family name. Please note that, once created, this cannot be updated except by the team member themself.
        /// </summary>
        [Input("lastName")]
        public Input<string>? LastName { get; set; }

        /// <summary>
        /// The role associated with team member. Supported roles are `reader`, `writer`, `no_access`, or `admin`. If you don't specify a role, `reader` is assigned by default.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        public TeamMemberArgs()
        {
        }
        public static new TeamMemberArgs Empty => new TeamMemberArgs();
    }

    public sealed class TeamMemberState : global::Pulumi.ResourceArgs
    {
        [Input("customRoles")]
        private InputList<string>? _customRoles;

        /// <summary>
        /// The list of custom roles keys associated with the team member. Custom roles are only available to customers on enterprise plans. To learn more about enterprise plans, contact sales@launchdarkly.com.
        /// 
        /// &gt; **Note:** each `launchdarkly.TeamMember` must have either a `role` or `custom_roles` argument.
        /// </summary>
        public InputList<string> CustomRoles
        {
            get => _customRoles ?? (_customRoles = new InputList<string>());
            set => _customRoles = value;
        }

        /// <summary>
        /// The unique email address associated with the team member. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// The team member's given name. Please note that, once created, this cannot be updated except by the team member themself.
        /// </summary>
        [Input("firstName")]
        public Input<string>? FirstName { get; set; }

        /// <summary>
        /// The team member's family name. Please note that, once created, this cannot be updated except by the team member themself.
        /// </summary>
        [Input("lastName")]
        public Input<string>? LastName { get; set; }

        /// <summary>
        /// The role associated with team member. Supported roles are `reader`, `writer`, `no_access`, or `admin`. If you don't specify a role, `reader` is assigned by default.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        public TeamMemberState()
        {
        }
        public static new TeamMemberState Empty => new TeamMemberState();
    }
}
