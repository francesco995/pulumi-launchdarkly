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
    ///     var readerToken = new Launchdarkly.AccessToken("readerToken", new()
    ///     {
    ///         Role = "reader",
    ///     });
    /// 
    ///     // With a custom role
    ///     var customRoleToken = new Launchdarkly.AccessToken("customRoleToken", new()
    ///     {
    ///         CustomRoles = new[]
    ///         {
    ///             "ops",
    ///         },
    ///     });
    /// 
    ///     // With an inline custom role (policy statements)
    ///     var tokenWithPolicyStatements = new Launchdarkly.AccessToken("tokenWithPolicyStatements", new()
    ///     {
    ///         InlineRoles = new[]
    ///         {
    ///             new Launchdarkly.Inputs.AccessTokenInlineRoleArgs
    ///             {
    ///                 Actions = new[]
    ///                 {
    ///                     "*",
    ///                 },
    ///                 Effect = "deny",
    ///                 Resources = new[]
    ///                 {
    ///                     "proj/*:env/production",
    ///                 },
    ///             },
    ///         },
    ///         ServiceToken = true,
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [LaunchdarklyResourceType("launchdarkly:index/accessToken:AccessToken")]
    public partial class AccessToken : global::Pulumi.CustomResource
    {
        /// <summary>
        /// A list of custom role IDs to use as access limits for the access token.
        /// </summary>
        [Output("customRoles")]
        public Output<ImmutableArray<string>> CustomRoles { get; private set; } = null!;

        /// <summary>
        /// The default API version for this token. Defaults to the latest API version. A change in this field will force the destruction of the existing token in state and the creation of a new one.
        /// </summary>
        [Output("defaultApiVersion")]
        public Output<int> DefaultApiVersion { get; private set; } = null!;

        /// <summary>
        /// An expiration time for the current token secret, expressed as a Unix epoch time. Replace the computed token secret with a new value. The expired secret will no longer be able to authorize usage of the LaunchDarkly API. This field argument is **deprecated**. Please update your config to remove `expire` to maintain compatibility with future versions
        /// </summary>
        [Output("expire")]
        public Output<int?> Expire { get; private set; } = null!;

        /// <summary>
        /// Define inline custom roles. An array of statements represented as config blocks with three attributes: effect, resources, actions. May be used in place of a built-in or custom role. [Using polices](https://docs.launchdarkly.com/home/members/role-policies). May be specified more than once.
        /// </summary>
        [Output("inlineRoles")]
        public Output<ImmutableArray<Outputs.AccessTokenInlineRole>> InlineRoles { get; private set; } = null!;

        /// <summary>
        /// A human-friendly name for the access token.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Define inline custom roles. An array of statements represented as config blocks with three attributes: effect, resources, actions. May be used in place of a built-in or custom role. May be specified more than once. This field argument is **deprecated**. Update your config to use `inline_role` to maintain compatibility with future versions.
        /// </summary>
        [Output("policyStatements")]
        public Output<ImmutableArray<Outputs.AccessTokenPolicyStatement>> PolicyStatements { get; private set; } = null!;

        /// <summary>
        /// A built-in LaunchDarkly role. Can be `reader`, `writer`, or `admin`
        /// </summary>
        [Output("role")]
        public Output<string?> Role { get; private set; } = null!;

        /// <summary>
        /// Whether the token will be a [service token](https://docs.launchdarkly.com/home/account-security/api-access-tokens#service-tokens). A change in this field will force the destruction of the existing token and the creation of a new one.
        /// </summary>
        [Output("serviceToken")]
        public Output<bool?> ServiceToken { get; private set; } = null!;

        /// <summary>
        /// The access token used to authorize usage of the LaunchDarkly API.
        /// </summary>
        [Output("token")]
        public Output<string> Token { get; private set; } = null!;


        /// <summary>
        /// Create a AccessToken resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccessToken(string name, AccessTokenArgs? args = null, CustomResourceOptions? options = null)
            : base("launchdarkly:index/accessToken:AccessToken", name, args ?? new AccessTokenArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AccessToken(string name, Input<string> id, AccessTokenState? state = null, CustomResourceOptions? options = null)
            : base("launchdarkly:index/accessToken:AccessToken", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                AdditionalSecretOutputs =
                {
                    "token",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AccessToken resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccessToken Get(string name, Input<string> id, AccessTokenState? state = null, CustomResourceOptions? options = null)
        {
            return new AccessToken(name, id, state, options);
        }
    }

    public sealed class AccessTokenArgs : global::Pulumi.ResourceArgs
    {
        [Input("customRoles")]
        private InputList<string>? _customRoles;

        /// <summary>
        /// A list of custom role IDs to use as access limits for the access token.
        /// </summary>
        public InputList<string> CustomRoles
        {
            get => _customRoles ?? (_customRoles = new InputList<string>());
            set => _customRoles = value;
        }

        /// <summary>
        /// The default API version for this token. Defaults to the latest API version. A change in this field will force the destruction of the existing token in state and the creation of a new one.
        /// </summary>
        [Input("defaultApiVersion")]
        public Input<int>? DefaultApiVersion { get; set; }

        /// <summary>
        /// An expiration time for the current token secret, expressed as a Unix epoch time. Replace the computed token secret with a new value. The expired secret will no longer be able to authorize usage of the LaunchDarkly API. This field argument is **deprecated**. Please update your config to remove `expire` to maintain compatibility with future versions
        /// </summary>
        [Input("expire")]
        public Input<int>? Expire { get; set; }

        [Input("inlineRoles")]
        private InputList<Inputs.AccessTokenInlineRoleArgs>? _inlineRoles;

        /// <summary>
        /// Define inline custom roles. An array of statements represented as config blocks with three attributes: effect, resources, actions. May be used in place of a built-in or custom role. [Using polices](https://docs.launchdarkly.com/home/members/role-policies). May be specified more than once.
        /// </summary>
        public InputList<Inputs.AccessTokenInlineRoleArgs> InlineRoles
        {
            get => _inlineRoles ?? (_inlineRoles = new InputList<Inputs.AccessTokenInlineRoleArgs>());
            set => _inlineRoles = value;
        }

        /// <summary>
        /// A human-friendly name for the access token.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("policyStatements")]
        private InputList<Inputs.AccessTokenPolicyStatementArgs>? _policyStatements;

        /// <summary>
        /// Define inline custom roles. An array of statements represented as config blocks with three attributes: effect, resources, actions. May be used in place of a built-in or custom role. May be specified more than once. This field argument is **deprecated**. Update your config to use `inline_role` to maintain compatibility with future versions.
        /// </summary>
        [Obsolete(@"'policy_statements' is deprecated in favor of 'inline_roles'. This field will be removed in the next major release of the LaunchDarkly provider")]
        public InputList<Inputs.AccessTokenPolicyStatementArgs> PolicyStatements
        {
            get => _policyStatements ?? (_policyStatements = new InputList<Inputs.AccessTokenPolicyStatementArgs>());
            set => _policyStatements = value;
        }

        /// <summary>
        /// A built-in LaunchDarkly role. Can be `reader`, `writer`, or `admin`
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// Whether the token will be a [service token](https://docs.launchdarkly.com/home/account-security/api-access-tokens#service-tokens). A change in this field will force the destruction of the existing token and the creation of a new one.
        /// </summary>
        [Input("serviceToken")]
        public Input<bool>? ServiceToken { get; set; }

        public AccessTokenArgs()
        {
        }
        public static new AccessTokenArgs Empty => new AccessTokenArgs();
    }

    public sealed class AccessTokenState : global::Pulumi.ResourceArgs
    {
        [Input("customRoles")]
        private InputList<string>? _customRoles;

        /// <summary>
        /// A list of custom role IDs to use as access limits for the access token.
        /// </summary>
        public InputList<string> CustomRoles
        {
            get => _customRoles ?? (_customRoles = new InputList<string>());
            set => _customRoles = value;
        }

        /// <summary>
        /// The default API version for this token. Defaults to the latest API version. A change in this field will force the destruction of the existing token in state and the creation of a new one.
        /// </summary>
        [Input("defaultApiVersion")]
        public Input<int>? DefaultApiVersion { get; set; }

        /// <summary>
        /// An expiration time for the current token secret, expressed as a Unix epoch time. Replace the computed token secret with a new value. The expired secret will no longer be able to authorize usage of the LaunchDarkly API. This field argument is **deprecated**. Please update your config to remove `expire` to maintain compatibility with future versions
        /// </summary>
        [Input("expire")]
        public Input<int>? Expire { get; set; }

        [Input("inlineRoles")]
        private InputList<Inputs.AccessTokenInlineRoleGetArgs>? _inlineRoles;

        /// <summary>
        /// Define inline custom roles. An array of statements represented as config blocks with three attributes: effect, resources, actions. May be used in place of a built-in or custom role. [Using polices](https://docs.launchdarkly.com/home/members/role-policies). May be specified more than once.
        /// </summary>
        public InputList<Inputs.AccessTokenInlineRoleGetArgs> InlineRoles
        {
            get => _inlineRoles ?? (_inlineRoles = new InputList<Inputs.AccessTokenInlineRoleGetArgs>());
            set => _inlineRoles = value;
        }

        /// <summary>
        /// A human-friendly name for the access token.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("policyStatements")]
        private InputList<Inputs.AccessTokenPolicyStatementGetArgs>? _policyStatements;

        /// <summary>
        /// Define inline custom roles. An array of statements represented as config blocks with three attributes: effect, resources, actions. May be used in place of a built-in or custom role. May be specified more than once. This field argument is **deprecated**. Update your config to use `inline_role` to maintain compatibility with future versions.
        /// </summary>
        [Obsolete(@"'policy_statements' is deprecated in favor of 'inline_roles'. This field will be removed in the next major release of the LaunchDarkly provider")]
        public InputList<Inputs.AccessTokenPolicyStatementGetArgs> PolicyStatements
        {
            get => _policyStatements ?? (_policyStatements = new InputList<Inputs.AccessTokenPolicyStatementGetArgs>());
            set => _policyStatements = value;
        }

        /// <summary>
        /// A built-in LaunchDarkly role. Can be `reader`, `writer`, or `admin`
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// Whether the token will be a [service token](https://docs.launchdarkly.com/home/account-security/api-access-tokens#service-tokens). A change in this field will force the destruction of the existing token and the creation of a new one.
        /// </summary>
        [Input("serviceToken")]
        public Input<bool>? ServiceToken { get; set; }

        [Input("token")]
        private Input<string>? _token;

        /// <summary>
        /// The access token used to authorize usage of the LaunchDarkly API.
        /// </summary>
        public Input<string>? Token
        {
            get => _token;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _token = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public AccessTokenState()
        {
        }
        public static new AccessTokenState Empty => new AccessTokenState();
    }
}