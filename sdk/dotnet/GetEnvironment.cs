// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly
{
    public static class GetEnvironment
    {
        /// <summary>
        /// Provides a LaunchDarkly environment data source.
        /// 
        /// This data source allows you to retrieve environment information from your LaunchDarkly organization.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Launchdarkly = Pulumi.Launchdarkly;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var example = Launchdarkly.GetEnvironment.Invoke(new()
        ///     {
        ///         Key = "example-env",
        ///         ProjectKey = "example-project",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetEnvironmentResult> InvokeAsync(GetEnvironmentArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetEnvironmentResult>("launchdarkly:index/getEnvironment:getEnvironment", args ?? new GetEnvironmentArgs(), options.WithDefaults());

        /// <summary>
        /// Provides a LaunchDarkly environment data source.
        /// 
        /// This data source allows you to retrieve environment information from your LaunchDarkly organization.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Launchdarkly = Pulumi.Launchdarkly;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var example = Launchdarkly.GetEnvironment.Invoke(new()
        ///     {
        ///         Key = "example-env",
        ///         ProjectKey = "example-project",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetEnvironmentResult> Invoke(GetEnvironmentInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetEnvironmentResult>("launchdarkly:index/getEnvironment:getEnvironment", args ?? new GetEnvironmentInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEnvironmentArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The project-unique key for the environment.
        /// </summary>
        [Input("key", required: true)]
        public string Key { get; set; } = null!;

        /// <summary>
        /// The environment's project key.
        /// </summary>
        [Input("projectKey", required: true)]
        public string ProjectKey { get; set; } = null!;

        public GetEnvironmentArgs()
        {
        }
        public static new GetEnvironmentArgs Empty => new GetEnvironmentArgs();
    }

    public sealed class GetEnvironmentInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The project-unique key for the environment.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The environment's project key.
        /// </summary>
        [Input("projectKey", required: true)]
        public Input<string> ProjectKey { get; set; } = null!;

        public GetEnvironmentInvokeArgs()
        {
        }
        public static new GetEnvironmentInvokeArgs Empty => new GetEnvironmentInvokeArgs();
    }


    [OutputType]
    public sealed class GetEnvironmentResult
    {
        /// <summary>
        /// The environment's SDK key.
        /// </summary>
        public readonly string ApiKey;
        public readonly ImmutableArray<Outputs.GetEnvironmentApprovalSettingResult> ApprovalSettings;
        /// <summary>
        /// The environment's client-side ID.
        /// </summary>
        public readonly string ClientSideId;
        public readonly string Color;
        /// <summary>
        /// Set to `true` if this environment requires confirmation for flag and segment changes. This field will default to `false` when not set.
        /// </summary>
        public readonly bool ConfirmChanges;
        /// <summary>
        /// Set to `true` to enable data export for every flag created in this environment after you configure this argument. This field will default to `false` when not set. To learn more, read [Data Export](https://docs.launchdarkly.com/home/data-export).
        /// </summary>
        public readonly bool DefaultTrackEvents;
        /// <summary>
        /// The TTL for the environment. This must be between 0 and 60 minutes. The TTL setting only applies to environments using the PHP SDK. This field will default to `0` when not set. To learn more, read [TTL settings](https://docs.launchdarkly.com/home/organize/environments#ttl-settings).
        /// </summary>
        public readonly int DefaultTtl;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The project-unique key for the environment.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// The environment's mobile key.
        /// </summary>
        public readonly string MobileKey;
        public readonly string Name;
        /// <summary>
        /// The environment's project key.
        /// </summary>
        public readonly string ProjectKey;
        /// <summary>
        /// Set to `true` if this environment requires comments for flag and segment changes. This field will default to `false` when not set.
        /// </summary>
        public readonly bool RequireComments;
        /// <summary>
        /// Set to `true` to ensure a user of the client-side SDK cannot impersonate another user. This field will default to `false` when not set.
        /// </summary>
        public readonly bool SecureMode;
        /// <summary>
        /// Tags associated with your resource.
        /// </summary>
        public readonly ImmutableArray<string> Tags;

        [OutputConstructor]
        private GetEnvironmentResult(
            string apiKey,

            ImmutableArray<Outputs.GetEnvironmentApprovalSettingResult> approvalSettings,

            string clientSideId,

            string color,

            bool confirmChanges,

            bool defaultTrackEvents,

            int defaultTtl,

            string id,

            string key,

            string mobileKey,

            string name,

            string projectKey,

            bool requireComments,

            bool secureMode,

            ImmutableArray<string> tags)
        {
            ApiKey = apiKey;
            ApprovalSettings = approvalSettings;
            ClientSideId = clientSideId;
            Color = color;
            ConfirmChanges = confirmChanges;
            DefaultTrackEvents = defaultTrackEvents;
            DefaultTtl = defaultTtl;
            Id = id;
            Key = key;
            MobileKey = mobileKey;
            Name = name;
            ProjectKey = projectKey;
            RequireComments = requireComments;
            SecureMode = secureMode;
            Tags = tags;
        }
    }
}
