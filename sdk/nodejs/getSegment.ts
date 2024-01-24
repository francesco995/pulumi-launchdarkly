// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a LaunchDarkly segment data source.
 *
 * This data source allows you to retrieve segment information from your LaunchDarkly organization.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as launchdarkly from "@pulumi/launchdarkly";
 *
 * const example = launchdarkly.getSegment({
 *     envKey: "example-env",
 *     key: "example-segment",
 *     projectKey: "example-project",
 * });
 * ```
 */
export function getSegment(args: GetSegmentArgs, opts?: pulumi.InvokeOptions): Promise<GetSegmentResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("launchdarkly:index/getSegment:getSegment", {
        "envKey": args.envKey,
        "key": args.key,
        "projectKey": args.projectKey,
    }, opts);
}

/**
 * A collection of arguments for invoking getSegment.
 */
export interface GetSegmentArgs {
    /**
     * The segment's environment key.
     */
    envKey: string;
    /**
     * The unique key that references the segment.
     */
    key: string;
    /**
     * The segment's project key.
     */
    projectKey: string;
}

/**
 * A collection of values returned by getSegment.
 */
export interface GetSegmentResult {
    /**
     * The segment's creation date represented as a UNIX epoch timestamp.
     */
    readonly creationDate: number;
    /**
     * The description of the segment's purpose.
     */
    readonly description: string;
    /**
     * The segment's environment key.
     */
    readonly envKey: string;
    /**
     * List of non-user target objects excluded from the segment. This attribute is not valid when `unbounded` is set to `true`.
     */
    readonly excludedContexts: outputs.GetSegmentExcludedContext[];
    /**
     * List of user keys excluded from the segment. To target on other context kinds, use the excludedContexts block attribute. This attribute is not valid when `unbounded` is set to `true`.
     */
    readonly excludeds: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * List of non-user target objects included in the segment. This attribute is not valid when `unbounded` is set to `true`.
     */
    readonly includedContexts: outputs.GetSegmentIncludedContext[];
    /**
     * List of user keys included in the segment. To target on other context kinds, use the includedContexts block attribute. This attribute is not valid when `unbounded` is set to `true`.
     */
    readonly includeds: string[];
    /**
     * The unique key that references the segment.
     */
    readonly key: string;
    /**
     * The human-friendly name for the segment.
     */
    readonly name: string;
    /**
     * The segment's project key.
     */
    readonly projectKey: string;
    /**
     * List of nested custom rule blocks to apply to the segment. This attribute is not valid when `unbounded` is set to `true`.
     */
    readonly rules: outputs.GetSegmentRule[];
    /**
     * Tags associated with your resource.
     */
    readonly tags: string[];
    readonly unbounded: boolean;
    /**
     * For Big Segments, the targeted context kind. If this attribute is not specified it will default to `user`.
     */
    readonly unboundedContextKind: string;
}
/**
 * Provides a LaunchDarkly segment data source.
 *
 * This data source allows you to retrieve segment information from your LaunchDarkly organization.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as launchdarkly from "@pulumi/launchdarkly";
 *
 * const example = launchdarkly.getSegment({
 *     envKey: "example-env",
 *     key: "example-segment",
 *     projectKey: "example-project",
 * });
 * ```
 */
export function getSegmentOutput(args: GetSegmentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSegmentResult> {
    return pulumi.output(args).apply((a: any) => getSegment(a, opts))
}

/**
 * A collection of arguments for invoking getSegment.
 */
export interface GetSegmentOutputArgs {
    /**
     * The segment's environment key.
     */
    envKey: pulumi.Input<string>;
    /**
     * The unique key that references the segment.
     */
    key: pulumi.Input<string>;
    /**
     * The segment's project key.
     */
    projectKey: pulumi.Input<string>;
}
