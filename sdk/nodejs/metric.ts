// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a LaunchDarkly metric resource.
 *
 * This resource allows you to create and manage metrics within your LaunchDarkly organization.
 *
 * To learn more about metrics and experimentation, read [Experimentation Documentation](https://docs.launchdarkly.com/home/experimentation).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as launchdarkly from "@pulumi/launchdarkly";
 *
 * const example = new launchdarkly.Metric("example", {
 *     projectKey: launchdarkly_project.example.key,
 *     key: "example-metric",
 *     description: "Metric description.",
 *     kind: "pageview",
 *     tags: ["example"],
 *     urls: [{
 *         kind: "substring",
 *         substring: "foo",
 *     }],
 * });
 * ```
 *
 * ## Import
 *
 * LaunchDarkly metrics can be imported using the metric's ID in the form `project_key/metric_key`, e.g.
 *
 * ```sh
 *  $ pulumi import launchdarkly:index/metric:Metric example example-project/example-metric-key
 * ```
 */
export class Metric extends pulumi.CustomResource {
    /**
     * Get an existing Metric resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MetricState, opts?: pulumi.CustomResourceOptions): Metric {
        return new Metric(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'launchdarkly:index/metric:Metric';

    /**
     * Returns true if the given object is an instance of Metric.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Metric {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Metric.__pulumiType;
    }

    /**
     * The description of the metric's purpose.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The event key to watch for `custom` metrics.
     */
    public readonly eventKey!: pulumi.Output<string | undefined>;
    /**
     * Whether a metric is a active.
     */
    public readonly isActive!: pulumi.Output<boolean | undefined>;
    /**
     * Whether a `custom` metric is a numeric metric or not.
     */
    public readonly isNumeric!: pulumi.Output<boolean | undefined>;
    /**
     * The unique key that references the metric. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    public readonly key!: pulumi.Output<string>;
    /**
     * The metric type. Available choices are `click`, `custom`, and `pageview`. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    public readonly kind!: pulumi.Output<string>;
    /**
     * The userId of the user maintaining the metric.
     */
    public readonly maintainerId!: pulumi.Output<string>;
    /**
     * The human-friendly name for the metric.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The metrics's project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    public readonly projectKey!: pulumi.Output<string>;
    /**
     * A set of one or more context kinds that this metric can measure events from. Metrics can only use context kinds marked as "Available for experiments." For more information, read [Allocating experiment audiences](https://docs.launchdarkly.com/home/creating-experiments/allocation)
     */
    public readonly randomizationUnits!: pulumi.Output<string[]>;
    /**
     * The CSS selector for `click` metrics.
     */
    public readonly selector!: pulumi.Output<string | undefined>;
    /**
     * The success criteria for numeric `custom` metrics.
     */
    public readonly successCriteria!: pulumi.Output<string | undefined>;
    /**
     * Set of tags for the metric.
     */
    public readonly tags!: pulumi.Output<string[] | undefined>;
    /**
     * The unit for numeric `custom` metrics.
     */
    public readonly unit!: pulumi.Output<string | undefined>;
    /**
     * A block determining which URLs the metric watches. To learn more, read Nested Urls Blocks.
     */
    public readonly urls!: pulumi.Output<outputs.MetricUrl[] | undefined>;

    /**
     * Create a Metric resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MetricArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MetricArgs | MetricState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MetricState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["eventKey"] = state ? state.eventKey : undefined;
            resourceInputs["isActive"] = state ? state.isActive : undefined;
            resourceInputs["isNumeric"] = state ? state.isNumeric : undefined;
            resourceInputs["key"] = state ? state.key : undefined;
            resourceInputs["kind"] = state ? state.kind : undefined;
            resourceInputs["maintainerId"] = state ? state.maintainerId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["projectKey"] = state ? state.projectKey : undefined;
            resourceInputs["randomizationUnits"] = state ? state.randomizationUnits : undefined;
            resourceInputs["selector"] = state ? state.selector : undefined;
            resourceInputs["successCriteria"] = state ? state.successCriteria : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["unit"] = state ? state.unit : undefined;
            resourceInputs["urls"] = state ? state.urls : undefined;
        } else {
            const args = argsOrState as MetricArgs | undefined;
            if ((!args || args.key === undefined) && !opts.urn) {
                throw new Error("Missing required property 'key'");
            }
            if ((!args || args.kind === undefined) && !opts.urn) {
                throw new Error("Missing required property 'kind'");
            }
            if ((!args || args.projectKey === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectKey'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["eventKey"] = args ? args.eventKey : undefined;
            resourceInputs["isActive"] = args ? args.isActive : undefined;
            resourceInputs["isNumeric"] = args ? args.isNumeric : undefined;
            resourceInputs["key"] = args ? args.key : undefined;
            resourceInputs["kind"] = args ? args.kind : undefined;
            resourceInputs["maintainerId"] = args ? args.maintainerId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["projectKey"] = args ? args.projectKey : undefined;
            resourceInputs["randomizationUnits"] = args ? args.randomizationUnits : undefined;
            resourceInputs["selector"] = args ? args.selector : undefined;
            resourceInputs["successCriteria"] = args ? args.successCriteria : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["unit"] = args ? args.unit : undefined;
            resourceInputs["urls"] = args ? args.urls : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Metric.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Metric resources.
 */
export interface MetricState {
    /**
     * The description of the metric's purpose.
     */
    description?: pulumi.Input<string>;
    /**
     * The event key to watch for `custom` metrics.
     */
    eventKey?: pulumi.Input<string>;
    /**
     * Whether a metric is a active.
     */
    isActive?: pulumi.Input<boolean>;
    /**
     * Whether a `custom` metric is a numeric metric or not.
     */
    isNumeric?: pulumi.Input<boolean>;
    /**
     * The unique key that references the metric. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    key?: pulumi.Input<string>;
    /**
     * The metric type. Available choices are `click`, `custom`, and `pageview`. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    kind?: pulumi.Input<string>;
    /**
     * The userId of the user maintaining the metric.
     */
    maintainerId?: pulumi.Input<string>;
    /**
     * The human-friendly name for the metric.
     */
    name?: pulumi.Input<string>;
    /**
     * The metrics's project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    projectKey?: pulumi.Input<string>;
    /**
     * A set of one or more context kinds that this metric can measure events from. Metrics can only use context kinds marked as "Available for experiments." For more information, read [Allocating experiment audiences](https://docs.launchdarkly.com/home/creating-experiments/allocation)
     */
    randomizationUnits?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The CSS selector for `click` metrics.
     */
    selector?: pulumi.Input<string>;
    /**
     * The success criteria for numeric `custom` metrics.
     */
    successCriteria?: pulumi.Input<string>;
    /**
     * Set of tags for the metric.
     */
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The unit for numeric `custom` metrics.
     */
    unit?: pulumi.Input<string>;
    /**
     * A block determining which URLs the metric watches. To learn more, read Nested Urls Blocks.
     */
    urls?: pulumi.Input<pulumi.Input<inputs.MetricUrl>[]>;
}

/**
 * The set of arguments for constructing a Metric resource.
 */
export interface MetricArgs {
    /**
     * The description of the metric's purpose.
     */
    description?: pulumi.Input<string>;
    /**
     * The event key to watch for `custom` metrics.
     */
    eventKey?: pulumi.Input<string>;
    /**
     * Whether a metric is a active.
     */
    isActive?: pulumi.Input<boolean>;
    /**
     * Whether a `custom` metric is a numeric metric or not.
     */
    isNumeric?: pulumi.Input<boolean>;
    /**
     * The unique key that references the metric. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    key: pulumi.Input<string>;
    /**
     * The metric type. Available choices are `click`, `custom`, and `pageview`. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    kind: pulumi.Input<string>;
    /**
     * The userId of the user maintaining the metric.
     */
    maintainerId?: pulumi.Input<string>;
    /**
     * The human-friendly name for the metric.
     */
    name?: pulumi.Input<string>;
    /**
     * The metrics's project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
     */
    projectKey: pulumi.Input<string>;
    /**
     * A set of one or more context kinds that this metric can measure events from. Metrics can only use context kinds marked as "Available for experiments." For more information, read [Allocating experiment audiences](https://docs.launchdarkly.com/home/creating-experiments/allocation)
     */
    randomizationUnits?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The CSS selector for `click` metrics.
     */
    selector?: pulumi.Input<string>;
    /**
     * The success criteria for numeric `custom` metrics.
     */
    successCriteria?: pulumi.Input<string>;
    /**
     * Set of tags for the metric.
     */
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The unit for numeric `custom` metrics.
     */
    unit?: pulumi.Input<string>;
    /**
     * A block determining which URLs the metric watches. To learn more, read Nested Urls Blocks.
     */
    urls?: pulumi.Input<pulumi.Input<inputs.MetricUrl>[]>;
}
