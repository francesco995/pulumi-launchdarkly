// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a LaunchDarkly team members data source.
 *
 * This data source allows you to retrieve team member information from your LaunchDarkly organization on multiple team members.
 */
export function getTeamMembers(args: GetTeamMembersArgs, opts?: pulumi.InvokeOptions): Promise<GetTeamMembersResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("launchdarkly:index/getTeamMembers:getTeamMembers", {
        "emails": args.emails,
        "ignoreMissing": args.ignoreMissing,
    }, opts);
}

/**
 * A collection of arguments for invoking getTeamMembers.
 */
export interface GetTeamMembersArgs {
    /**
     * An array of unique email addresses associated with the team members.
     */
    emails: string[];
    /**
     * A boolean to determine whether to ignore members that weren't found.
     */
    ignoreMissing?: boolean;
}

/**
 * A collection of values returned by getTeamMembers.
 */
export interface GetTeamMembersResult {
    readonly emails: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly ignoreMissing?: boolean;
    readonly teamMembers: outputs.GetTeamMembersTeamMember[];
}
/**
 * Provides a LaunchDarkly team members data source.
 *
 * This data source allows you to retrieve team member information from your LaunchDarkly organization on multiple team members.
 */
export function getTeamMembersOutput(args: GetTeamMembersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTeamMembersResult> {
    return pulumi.output(args).apply((a: any) => getTeamMembers(a, opts))
}

/**
 * A collection of arguments for invoking getTeamMembers.
 */
export interface GetTeamMembersOutputArgs {
    /**
     * An array of unique email addresses associated with the team members.
     */
    emails: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A boolean to determine whether to ignore members that weren't found.
     */
    ignoreMissing?: pulumi.Input<boolean>;
}
