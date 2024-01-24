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
    /// Provides a LaunchDarkly segment resource.
    /// 
    /// This resource allows you to create and manage segments within your LaunchDarkly organization.
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
    ///     var example = new Launchdarkly.Segment("example", new()
    ///     {
    ///         Key = "example-segment-key",
    ///         ProjectKey = launchdarkly_project.Example.Key,
    ///         EnvKey = launchdarkly_environment.Example.Key,
    ///         Description = "This segment is managed by Terraform",
    ///         Tags = new[]
    ///         {
    ///             "segment-tag-1",
    ///             "segment-tag-2",
    ///         },
    ///         Includeds = new[]
    ///         {
    ///             "user1",
    ///             "user2",
    ///         },
    ///         Excludeds = new[]
    ///         {
    ///             "user3",
    ///             "user4",
    ///         },
    ///         IncludedContexts = new[]
    ///         {
    ///             new Launchdarkly.Inputs.SegmentIncludedContextArgs
    ///             {
    ///                 Values = new[]
    ///                 {
    ///                     "account1",
    ///                     "account2",
    ///                 },
    ///                 ContextKind = "account",
    ///             },
    ///         },
    ///         Rules = new[]
    ///         {
    ///             new Launchdarkly.Inputs.SegmentRuleArgs
    ///             {
    ///                 Clauses = new[]
    ///                 {
    ///                     new Launchdarkly.Inputs.SegmentRuleClauseArgs
    ///                     {
    ///                         Attribute = "country",
    ///                         Op = "startsWith",
    ///                         Values = new[]
    ///                         {
    ///                             "en",
    ///                             "de",
    ///                             "un",
    ///                         },
    ///                         Negate = false,
    ///                         ContextKind = "location-data",
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    ///     var big_example = new Launchdarkly.Segment("big-example", new()
    ///     {
    ///         Key = "example-big-segment-key",
    ///         ProjectKey = launchdarkly_project.Example.Key,
    ///         EnvKey = launchdarkly_environment.Example.Key,
    ///         Description = "This big segment is managed by Terraform",
    ///         Tags = new[]
    ///         {
    ///             "segment-tag-1",
    ///             "segment-tag-2",
    ///         },
    ///         Unbounded = true,
    ///         UnboundedContextKind = "user",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// #LaunchDarkly segments can be imported using the segment's ID in the form `project_key/env_key/segment_key`
    /// 
    /// ```sh
    ///  $ pulumi import launchdarkly:index/segment:Segment example example-project/example-environment/example-segment-key
    /// ```
    /// </summary>
    [LaunchdarklyResourceType("launchdarkly:index/segment:Segment")]
    public partial class Segment : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The segment's creation date represented as a UNIX epoch timestamp.
        /// </summary>
        [Output("creationDate")]
        public Output<int> CreationDate { get; private set; } = null!;

        /// <summary>
        /// The description of the segment's purpose.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The segment's environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Output("envKey")]
        public Output<string> EnvKey { get; private set; } = null!;

        /// <summary>
        /// List of non-user target objects excluded from the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        [Output("excludedContexts")]
        public Output<ImmutableArray<Outputs.SegmentExcludedContext>> ExcludedContexts { get; private set; } = null!;

        /// <summary>
        /// List of user keys excluded from the segment. To target on other context kinds, use the excluded_contexts block attribute. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        [Output("excludeds")]
        public Output<ImmutableArray<string>> Excludeds { get; private set; } = null!;

        /// <summary>
        /// List of non-user target objects included in the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        [Output("includedContexts")]
        public Output<ImmutableArray<Outputs.SegmentIncludedContext>> IncludedContexts { get; private set; } = null!;

        /// <summary>
        /// List of user keys included in the segment. To target on other context kinds, use the included_contexts block attribute. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        [Output("includeds")]
        public Output<ImmutableArray<string>> Includeds { get; private set; } = null!;

        /// <summary>
        /// The unique key that references the segment. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Output("key")]
        public Output<string> Key { get; private set; } = null!;

        /// <summary>
        /// The human-friendly name for the segment.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The segment's project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Output("projectKey")]
        public Output<string> ProjectKey { get; private set; } = null!;

        /// <summary>
        /// List of nested custom rule blocks to apply to the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        [Output("rules")]
        public Output<ImmutableArray<Outputs.SegmentRule>> Rules { get; private set; } = null!;

        /// <summary>
        /// Tags associated with your resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// Whether to create a standard segment (`false`) or a Big Segment (`true`). Standard segments include rule-based and
        /// smaller list-based segments. Big Segments include larger list-based segments and synced segments. Only use a Big Segment
        /// if you need to add more than 15,000 individual targets. It is not possible to manage the list of targeted contexts for
        /// Big Segments with Terraform.
        /// </summary>
        [Output("unbounded")]
        public Output<bool?> Unbounded { get; private set; } = null!;

        /// <summary>
        /// For Big Segments, the targeted context kind. If this attribute is not specified it will default to `user`.
        /// </summary>
        [Output("unboundedContextKind")]
        public Output<string> UnboundedContextKind { get; private set; } = null!;


        /// <summary>
        /// Create a Segment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Segment(string name, SegmentArgs args, CustomResourceOptions? options = null)
            : base("launchdarkly:index/segment:Segment", name, args ?? new SegmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Segment(string name, Input<string> id, SegmentState? state = null, CustomResourceOptions? options = null)
            : base("launchdarkly:index/segment:Segment", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Segment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Segment Get(string name, Input<string> id, SegmentState? state = null, CustomResourceOptions? options = null)
        {
            return new Segment(name, id, state, options);
        }
    }

    public sealed class SegmentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the segment's purpose.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The segment's environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Input("envKey", required: true)]
        public Input<string> EnvKey { get; set; } = null!;

        [Input("excludedContexts")]
        private InputList<Inputs.SegmentExcludedContextArgs>? _excludedContexts;

        /// <summary>
        /// List of non-user target objects excluded from the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<Inputs.SegmentExcludedContextArgs> ExcludedContexts
        {
            get => _excludedContexts ?? (_excludedContexts = new InputList<Inputs.SegmentExcludedContextArgs>());
            set => _excludedContexts = value;
        }

        [Input("excludeds")]
        private InputList<string>? _excludeds;

        /// <summary>
        /// List of user keys excluded from the segment. To target on other context kinds, use the excluded_contexts block attribute. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<string> Excludeds
        {
            get => _excludeds ?? (_excludeds = new InputList<string>());
            set => _excludeds = value;
        }

        [Input("includedContexts")]
        private InputList<Inputs.SegmentIncludedContextArgs>? _includedContexts;

        /// <summary>
        /// List of non-user target objects included in the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<Inputs.SegmentIncludedContextArgs> IncludedContexts
        {
            get => _includedContexts ?? (_includedContexts = new InputList<Inputs.SegmentIncludedContextArgs>());
            set => _includedContexts = value;
        }

        [Input("includeds")]
        private InputList<string>? _includeds;

        /// <summary>
        /// List of user keys included in the segment. To target on other context kinds, use the included_contexts block attribute. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<string> Includeds
        {
            get => _includeds ?? (_includeds = new InputList<string>());
            set => _includeds = value;
        }

        /// <summary>
        /// The unique key that references the segment. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The human-friendly name for the segment.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The segment's project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Input("projectKey", required: true)]
        public Input<string> ProjectKey { get; set; } = null!;

        [Input("rules")]
        private InputList<Inputs.SegmentRuleArgs>? _rules;

        /// <summary>
        /// List of nested custom rule blocks to apply to the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<Inputs.SegmentRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.SegmentRuleArgs>());
            set => _rules = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Tags associated with your resource.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Whether to create a standard segment (`false`) or a Big Segment (`true`). Standard segments include rule-based and
        /// smaller list-based segments. Big Segments include larger list-based segments and synced segments. Only use a Big Segment
        /// if you need to add more than 15,000 individual targets. It is not possible to manage the list of targeted contexts for
        /// Big Segments with Terraform.
        /// </summary>
        [Input("unbounded")]
        public Input<bool>? Unbounded { get; set; }

        /// <summary>
        /// For Big Segments, the targeted context kind. If this attribute is not specified it will default to `user`.
        /// </summary>
        [Input("unboundedContextKind")]
        public Input<string>? UnboundedContextKind { get; set; }

        public SegmentArgs()
        {
        }
        public static new SegmentArgs Empty => new SegmentArgs();
    }

    public sealed class SegmentState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The segment's creation date represented as a UNIX epoch timestamp.
        /// </summary>
        [Input("creationDate")]
        public Input<int>? CreationDate { get; set; }

        /// <summary>
        /// The description of the segment's purpose.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The segment's environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Input("envKey")]
        public Input<string>? EnvKey { get; set; }

        [Input("excludedContexts")]
        private InputList<Inputs.SegmentExcludedContextGetArgs>? _excludedContexts;

        /// <summary>
        /// List of non-user target objects excluded from the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<Inputs.SegmentExcludedContextGetArgs> ExcludedContexts
        {
            get => _excludedContexts ?? (_excludedContexts = new InputList<Inputs.SegmentExcludedContextGetArgs>());
            set => _excludedContexts = value;
        }

        [Input("excludeds")]
        private InputList<string>? _excludeds;

        /// <summary>
        /// List of user keys excluded from the segment. To target on other context kinds, use the excluded_contexts block attribute. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<string> Excludeds
        {
            get => _excludeds ?? (_excludeds = new InputList<string>());
            set => _excludeds = value;
        }

        [Input("includedContexts")]
        private InputList<Inputs.SegmentIncludedContextGetArgs>? _includedContexts;

        /// <summary>
        /// List of non-user target objects included in the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<Inputs.SegmentIncludedContextGetArgs> IncludedContexts
        {
            get => _includedContexts ?? (_includedContexts = new InputList<Inputs.SegmentIncludedContextGetArgs>());
            set => _includedContexts = value;
        }

        [Input("includeds")]
        private InputList<string>? _includeds;

        /// <summary>
        /// List of user keys included in the segment. To target on other context kinds, use the included_contexts block attribute. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<string> Includeds
        {
            get => _includeds ?? (_includeds = new InputList<string>());
            set => _includeds = value;
        }

        /// <summary>
        /// The unique key that references the segment. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// The human-friendly name for the segment.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The segment's project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        /// </summary>
        [Input("projectKey")]
        public Input<string>? ProjectKey { get; set; }

        [Input("rules")]
        private InputList<Inputs.SegmentRuleGetArgs>? _rules;

        /// <summary>
        /// List of nested custom rule blocks to apply to the segment. This attribute is not valid when `unbounded` is set to `true`.
        /// </summary>
        public InputList<Inputs.SegmentRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.SegmentRuleGetArgs>());
            set => _rules = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Tags associated with your resource.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Whether to create a standard segment (`false`) or a Big Segment (`true`). Standard segments include rule-based and
        /// smaller list-based segments. Big Segments include larger list-based segments and synced segments. Only use a Big Segment
        /// if you need to add more than 15,000 individual targets. It is not possible to manage the list of targeted contexts for
        /// Big Segments with Terraform.
        /// </summary>
        [Input("unbounded")]
        public Input<bool>? Unbounded { get; set; }

        /// <summary>
        /// For Big Segments, the targeted context kind. If this attribute is not specified it will default to `user`.
        /// </summary>
        [Input("unboundedContextKind")]
        public Input<string>? UnboundedContextKind { get; set; }

        public SegmentState()
        {
        }
        public static new SegmentState Empty => new SegmentState();
    }
}