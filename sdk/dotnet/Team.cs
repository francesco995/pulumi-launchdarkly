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
    /// Provides a LaunchDarkly team resource.
    /// 
    /// This resource allows you to create and manage a team within your LaunchDarkly organization.
    /// 
    /// &gt; **Note:** Teams are available to customers on an Enterprise LaunchDarkly plan. To learn more, read about our pricing. To upgrade your plan, [contact LaunchDarkly Sales](https://launchdarkly.com/contact-sales/).
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
    ///     var platformTeam = new Launchdarkly.Team("platformTeam", new()
    ///     {
    ///         CustomRoleKeys = new[]
    ///         {
    ///             "platform",
    ///             "nomad-administrators",
    ///         },
    ///         Description = "Team to manage internal infrastructure",
    ///         Key = "platform_team",
    ///         Maintainers = new[]
    ///         {
    ///             "12ab3c45de678910abc12345",
    ///         },
    ///         MemberIds = new[]
    ///         {
    ///             "507f1f77bcf86cd799439011",
    ///             "569f183514f4432160000007",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// A LaunchDarkly team can be imported using the team key:
    /// 
    /// ```sh
    ///  $ pulumi import launchdarkly:index/team:Team platform_team platform_team
    /// ```
    /// </summary>
    [LaunchdarklyResourceType("launchdarkly:index/team:Team")]
    public partial class Team : global::Pulumi.CustomResource
    {
        /// <summary>
        /// List of custom role keys the team will access. The referenced custom roles must already exist in LaunchDarkly. If they don't, the provider may behave unexpectedly.
        /// </summary>
        [Output("customRoleKeys")]
        public Output<ImmutableArray<string>> CustomRoleKeys { get; private set; } = null!;

        /// <summary>
        /// The team description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The team key.
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// List of member IDs for users who maintain the team.
        /// </summary>
        [Output("maintainers")]
        public Output<ImmutableArray<string>> Maintainers { get; private set; } = null!;

        /// <summary>
        /// List of member IDs who belong to the team.
        /// </summary>
        [Output("memberIds")]
        public Output<ImmutableArray<string>> MemberIds { get; private set; } = null!;

        /// <summary>
        /// A human-friendly name for the team.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a Team resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Team(string name, TeamArgs args, CustomResourceOptions? options = null)
            : base("launchdarkly:index/team:Team", name, args ?? new TeamArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Team(string name, Input<string> id, TeamState? state = null, CustomResourceOptions? options = null)
            : base("launchdarkly:index/team:Team", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Team resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Team Get(string name, Input<string> id, TeamState? state = null, CustomResourceOptions? options = null)
        {
            return new Team(name, id, state, options);
        }
    }

    public sealed class TeamArgs : global::Pulumi.ResourceArgs
    {
        [Input("customRoleKeys")]
        private InputList<string>? _customRoleKeys;

        /// <summary>
        /// List of custom role keys the team will access. The referenced custom roles must already exist in LaunchDarkly. If they don't, the provider may behave unexpectedly.
        /// </summary>
        public InputList<string> CustomRoleKeys
        {
            get => _customRoleKeys ?? (_customRoleKeys = new InputList<string>());
            set => _customRoleKeys = value;
        }

        /// <summary>
        /// The team description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The team key.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("maintainers")]
        private InputList<string>? _maintainers;

        /// <summary>
        /// List of member IDs for users who maintain the team.
        /// </summary>
        public InputList<string> Maintainers
        {
            get => _maintainers ?? (_maintainers = new InputList<string>());
            set => _maintainers = value;
        }

        [Input("memberIds")]
        private InputList<string>? _memberIds;

        /// <summary>
        /// List of member IDs who belong to the team.
        /// </summary>
        public InputList<string> MemberIds
        {
            get => _memberIds ?? (_memberIds = new InputList<string>());
            set => _memberIds = value;
        }

        /// <summary>
        /// A human-friendly name for the team.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public TeamArgs()
        {
        }
        public static new TeamArgs Empty => new TeamArgs();
    }

    public sealed class TeamState : global::Pulumi.ResourceArgs
    {
        [Input("customRoleKeys")]
        private InputList<string>? _customRoleKeys;

        /// <summary>
        /// List of custom role keys the team will access. The referenced custom roles must already exist in LaunchDarkly. If they don't, the provider may behave unexpectedly.
        /// </summary>
        public InputList<string> CustomRoleKeys
        {
            get => _customRoleKeys ?? (_customRoleKeys = new InputList<string>());
            set => _customRoleKeys = value;
        }

        /// <summary>
        /// The team description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The team key.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("maintainers")]
        private InputList<string>? _maintainers;

        /// <summary>
        /// List of member IDs for users who maintain the team.
        /// </summary>
        public InputList<string> Maintainers
        {
            get => _maintainers ?? (_maintainers = new InputList<string>());
            set => _maintainers = value;
        }

        [Input("memberIds")]
        private InputList<string>? _memberIds;

        /// <summary>
        /// List of member IDs who belong to the team.
        /// </summary>
        public InputList<string> MemberIds
        {
            get => _memberIds ?? (_memberIds = new InputList<string>());
            set => _memberIds = value;
        }

        /// <summary>
        /// A human-friendly name for the team.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public TeamState()
        {
        }
        public static new TeamState Empty => new TeamState();
    }
}
