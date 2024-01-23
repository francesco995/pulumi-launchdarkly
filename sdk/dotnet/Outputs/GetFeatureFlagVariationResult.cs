// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Launchdarkly.Outputs
{

    [OutputType]
    public sealed class GetFeatureFlagVariationResult
    {
        public readonly string? Description;
        public readonly string? Name;
        public readonly string Value;

        [OutputConstructor]
        private GetFeatureFlagVariationResult(
            string? description,

            string? name,

            string value)
        {
            Description = description;
            Name = name;
            Value = value;
        }
    }
}
