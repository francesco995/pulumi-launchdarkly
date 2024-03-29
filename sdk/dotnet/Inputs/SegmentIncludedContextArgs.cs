// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly.Inputs
{

    public sealed class SegmentIncludedContextArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The context kind associated with this segment target. To target on user contexts, use the included and excluded attributes.
        /// </summary>
        [Input("contextKind", required: true)]
        public Input<string> ContextKind { get; set; } = null!;

        [Input("values", required: true)]
        private InputList<string>? _values;

        /// <summary>
        /// List of target object keys included in or excluded from the segment.
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public SegmentIncludedContextArgs()
        {
        }
        public static new SegmentIncludedContextArgs Empty => new SegmentIncludedContextArgs();
    }
}
