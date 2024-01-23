// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Immutable;

namespace Pulumi.Launchdarkly
{
    public static class Config
    {
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "IDE1006", Justification = 
        "Double underscore prefix used to avoid conflicts with variable names.")]
        private sealed class __Value<T>
        {
            private readonly Func<T> _getter;
            private T _value = default!;
            private bool _set;

            public __Value(Func<T> getter)
            {
                _getter = getter;
            }

            public T Get() => _set ? _value : _getter();

            public void Set(T value)
            {
                _value = value;
                _set = true;
            }
        }

        private static readonly global::Pulumi.Config __config = new global::Pulumi.Config("launchdarkly");

        private static readonly __Value<string?> _accessToken = new __Value<string?>(() => __config.Get("accessToken"));
        /// <summary>
        /// The [personal access token](https://docs.launchdarkly.com/home/account-security/api-access-tokens#personal-tokens) or
        /// [service token](https://docs.launchdarkly.com/home/account-security/api-access-tokens#service-tokens) used to
        /// authenticate with LaunchDarkly. You can also set this with the `LAUNCHDARKLY_ACCESS_TOKEN` environment variable. You
        /// must provide either `access_token` or `oauth_token`.
        /// </summary>
        public static string? AccessToken
        {
            get => _accessToken.Get();
            set => _accessToken.Set(value);
        }

        private static readonly __Value<string?> _apiHost = new __Value<string?>(() => __config.Get("apiHost"));
        /// <summary>
        /// The LaunchDarkly host address. If this argument is not specified, the default host address is
        /// `https://app.launchdarkly.com`
        /// </summary>
        public static string? ApiHost
        {
            get => _apiHost.Get();
            set => _apiHost.Set(value);
        }

        private static readonly __Value<int?> _httpTimeout = new __Value<int?>(() => __config.GetInt32("httpTimeout"));
        /// <summary>
        /// The HTTP timeout (in seconds) when making API calls to LaunchDarkly.
        /// </summary>
        public static int? HttpTimeout
        {
            get => _httpTimeout.Get();
            set => _httpTimeout.Set(value);
        }

        private static readonly __Value<string?> _oauthToken = new __Value<string?>(() => __config.Get("oauthToken"));
        /// <summary>
        /// An OAuth V2 token you use to authenticate with LaunchDarkly. You can also set this with the `LAUNCHDARKLY_OAUTH_TOKEN`
        /// environment variable. You must provide either `access_token` or `oauth_token`.
        /// </summary>
        public static string? OauthToken
        {
            get => _oauthToken.Get();
            set => _oauthToken.Set(value);
        }

    }
}
