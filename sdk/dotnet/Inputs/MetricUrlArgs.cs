// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly.Inputs
{

    public sealed class MetricUrlArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL type. Available choices are `exact`, `canonical`, `substring` and `regex`.
        /// </summary>
        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        /// <summary>
        /// The regex pattern to match by.
        /// </summary>
        [Input("pattern")]
        public Input<string>? Pattern { get; set; }

        /// <summary>
        /// The URL substring to match by.
        /// </summary>
        [Input("substring")]
        public Input<string>? Substring { get; set; }

        /// <summary>
        /// The exact or canonical URL.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public MetricUrlArgs()
        {
        }
        public static new MetricUrlArgs Empty => new MetricUrlArgs();
    }
}
