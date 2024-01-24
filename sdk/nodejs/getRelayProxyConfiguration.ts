// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as launchdarkly from "@pulumi/launchdarkly";
 *
 * const example = new launchdarkly.RelayProxyConfiguration("example", {policies: [{
 *     actions: ["*"],
 *     effect: "allow",
 *     resources: ["proj/*:env/*"],
 * }]});
 * ```
 */
export function getRelayProxyConfiguration(args: GetRelayProxyConfigurationArgs, opts?: pulumi.InvokeOptions): Promise<GetRelayProxyConfigurationResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("launchdarkly:index/getRelayProxyConfiguration:getRelayProxyConfiguration", {
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getRelayProxyConfiguration.
 */
export interface GetRelayProxyConfigurationArgs {
    /**
     * The Relay Proxy configuration's unique 24 character ID. The unique relay proxy ID can be found in the relay proxy edit page URL, which you can locate by clicking the three dot menu on your relay proxy item in the UI and selecting 'Edit configuration':
     *
     * ```typescript
     * import * as pulumi from "@pulumi/pulumi";
     * ```
     */
    id: string;
}

/**
 * A collection of values returned by getRelayProxyConfiguration.
 */
export interface GetRelayProxyConfigurationResult {
    /**
     * The last 4 characters of the Relay Proxy configuration's unique key.
     */
    readonly displayKey: string;
    readonly id: string;
    /**
     * The human-readable name for your Relay Proxy configuration.
     */
    readonly name: string;
    /**
     * The Relay Proxy configuration's rule policy block. This determines what content the Relay Proxy receives. To learn more, read [Understanding policies](https://docs.launchdarkly.com/home/members/role-policies#understanding-policies).
     */
    readonly policies: outputs.GetRelayProxyConfigurationPolicy[];
}
/**
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as launchdarkly from "@pulumi/launchdarkly";
 *
 * const example = new launchdarkly.RelayProxyConfiguration("example", {policies: [{
 *     actions: ["*"],
 *     effect: "allow",
 *     resources: ["proj/*:env/*"],
 * }]});
 * ```
 */
export function getRelayProxyConfigurationOutput(args: GetRelayProxyConfigurationOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRelayProxyConfigurationResult> {
    return pulumi.output(args).apply((a: any) => getRelayProxyConfiguration(a, opts))
}

/**
 * A collection of arguments for invoking getRelayProxyConfiguration.
 */
export interface GetRelayProxyConfigurationOutputArgs {
    /**
     * The Relay Proxy configuration's unique 24 character ID. The unique relay proxy ID can be found in the relay proxy edit page URL, which you can locate by clicking the three dot menu on your relay proxy item in the UI and selecting 'Edit configuration':
     *
     * ```typescript
     * import * as pulumi from "@pulumi/pulumi";
     * ```
     */
    id: pulumi.Input<string>;
}