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
    public sealed class SegmentRuleClause
    {
        /// <summary>
        /// The user attribute to operate on
        /// </summary>
        public readonly string Attribute;
        /// <summary>
        /// The context kind associated with this segment target. To target on user contexts, use the included and excluded attributes.
        /// </summary>
        public readonly string? ContextKind;
        /// <summary>
        /// Whether to negate the rule clause.
        /// </summary>
        public readonly bool? Negate;
        /// <summary>
        /// The operator associated with the rule clause. Available options are `in`, `endsWith`, `startsWith`, `matches`, `contains`, `lessThan`, `lessThanOrEqual`, `greaterThanOrEqual`, `before`, `after`, `segmentMatch`, `semVerEqual`, `semVerLessThan`, and `semVerGreaterThan`.
        /// </summary>
        public readonly string Op;
        /// <summary>
        /// The type for each of the clause's values. Available types are `boolean`, `string`, and `number`. If omitted, `value_type` defaults to `string`.
        /// </summary>
        public readonly string? ValueType;
        /// <summary>
        /// List of target object keys included in or excluded from the segment.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private SegmentRuleClause(
            string attribute,

            string? contextKind,

            bool? negate,

            string op,

            string? valueType,

            ImmutableArray<string> values)
        {
            Attribute = attribute;
            ContextKind = contextKind;
            Negate = negate;
            Op = op;
            ValueType = valueType;
            Values = values;
        }
    }
}