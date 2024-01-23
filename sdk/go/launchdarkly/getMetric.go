// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package launchdarkly

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-launchdarkly/sdk/go/launchdarkly/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a LaunchDarkly metric data source.
//
// This data source allows you to retrieve metric information from your LaunchDarkly organization.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-launchdarkly/sdk/go/launchdarkly"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := launchdarkly.LookupMetric(ctx, &launchdarkly.LookupMetricArgs{
//				Key:        "example-metric",
//				ProjectKey: "example-project",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupMetric(ctx *pulumi.Context, args *LookupMetricArgs, opts ...pulumi.InvokeOption) (*LookupMetricResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupMetricResult
	err := ctx.Invoke("launchdarkly:index/getMetric:getMetric", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMetric.
type LookupMetricArgs struct {
	// The description of the metric's purpose.
	Description *string `pulumi:"description"`
	// The event key to watch for `custom` metrics.
	EventKey *string `pulumi:"eventKey"`
	// Whether a metric is a active.
	IsActive *bool `pulumi:"isActive"`
	// Whether a `custom` metric is a numeric metric or not.
	IsNumeric *bool `pulumi:"isNumeric"`
	// The metric's unique key.
	Key string `pulumi:"key"`
	// The metric type. Available choices are `click`, `custom`, and `pageview`.
	Kind *string `pulumi:"kind"`
	// The userId of the user maintaining the metric.
	MaintainerId *string `pulumi:"maintainerId"`
	// The name of the metric.
	Name *string `pulumi:"name"`
	// The metric's project key.
	ProjectKey string `pulumi:"projectKey"`
	// A set of one or more context kinds that this metric can measure events from. Metrics can only use context kinds marked as "Available for experiments." For more information, read [Allocating experiment audiences](https://docs.launchdarkly.com/home/creating-experiments/allocation)
	RandomizationUnits []string `pulumi:"randomizationUnits"`
	// The CSS selector for `click` metrics.
	Selector *string `pulumi:"selector"`
	// The success criteria for numeric `custom` metrics.
	SuccessCriteria *string `pulumi:"successCriteria"`
	// The unit for numeric `custom` metrics.
	Unit *string `pulumi:"unit"`
	// Which URLs the metric watches.
	Urls []GetMetricUrl `pulumi:"urls"`
}

// A collection of values returned by getMetric.
type LookupMetricResult struct {
	// The description of the metric's purpose.
	Description *string `pulumi:"description"`
	// The event key to watch for `custom` metrics.
	EventKey *string `pulumi:"eventKey"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Whether a metric is a active.
	IsActive *bool `pulumi:"isActive"`
	// Whether a `custom` metric is a numeric metric or not.
	IsNumeric *bool  `pulumi:"isNumeric"`
	Key       string `pulumi:"key"`
	// The metric type. Available choices are `click`, `custom`, and `pageview`.
	Kind *string `pulumi:"kind"`
	// The userId of the user maintaining the metric.
	MaintainerId string `pulumi:"maintainerId"`
	// The name of the metric.
	Name *string `pulumi:"name"`
	// The metrics's project key.
	ProjectKey string `pulumi:"projectKey"`
	// A set of one or more context kinds that this metric can measure events from. Metrics can only use context kinds marked as "Available for experiments." For more information, read [Allocating experiment audiences](https://docs.launchdarkly.com/home/creating-experiments/allocation)
	RandomizationUnits []string `pulumi:"randomizationUnits"`
	// The CSS selector for `click` metrics.
	Selector *string `pulumi:"selector"`
	// The success criteria for numeric `custom` metrics.
	SuccessCriteria *string `pulumi:"successCriteria"`
	// Set of tags associated with the metric.
	Tags []string `pulumi:"tags"`
	// The unit for numeric `custom` metrics.
	Unit *string `pulumi:"unit"`
	// Which URLs the metric watches.
	Urls []GetMetricUrl `pulumi:"urls"`
}

func LookupMetricOutput(ctx *pulumi.Context, args LookupMetricOutputArgs, opts ...pulumi.InvokeOption) LookupMetricResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupMetricResult, error) {
			args := v.(LookupMetricArgs)
			r, err := LookupMetric(ctx, &args, opts...)
			var s LookupMetricResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupMetricResultOutput)
}

// A collection of arguments for invoking getMetric.
type LookupMetricOutputArgs struct {
	// The description of the metric's purpose.
	Description pulumi.StringPtrInput `pulumi:"description"`
	// The event key to watch for `custom` metrics.
	EventKey pulumi.StringPtrInput `pulumi:"eventKey"`
	// Whether a metric is a active.
	IsActive pulumi.BoolPtrInput `pulumi:"isActive"`
	// Whether a `custom` metric is a numeric metric or not.
	IsNumeric pulumi.BoolPtrInput `pulumi:"isNumeric"`
	// The metric's unique key.
	Key pulumi.StringInput `pulumi:"key"`
	// The metric type. Available choices are `click`, `custom`, and `pageview`.
	Kind pulumi.StringPtrInput `pulumi:"kind"`
	// The userId of the user maintaining the metric.
	MaintainerId pulumi.StringPtrInput `pulumi:"maintainerId"`
	// The name of the metric.
	Name pulumi.StringPtrInput `pulumi:"name"`
	// The metric's project key.
	ProjectKey pulumi.StringInput `pulumi:"projectKey"`
	// A set of one or more context kinds that this metric can measure events from. Metrics can only use context kinds marked as "Available for experiments." For more information, read [Allocating experiment audiences](https://docs.launchdarkly.com/home/creating-experiments/allocation)
	RandomizationUnits pulumi.StringArrayInput `pulumi:"randomizationUnits"`
	// The CSS selector for `click` metrics.
	Selector pulumi.StringPtrInput `pulumi:"selector"`
	// The success criteria for numeric `custom` metrics.
	SuccessCriteria pulumi.StringPtrInput `pulumi:"successCriteria"`
	// The unit for numeric `custom` metrics.
	Unit pulumi.StringPtrInput `pulumi:"unit"`
	// Which URLs the metric watches.
	Urls GetMetricUrlArrayInput `pulumi:"urls"`
}

func (LookupMetricOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMetricArgs)(nil)).Elem()
}

// A collection of values returned by getMetric.
type LookupMetricResultOutput struct{ *pulumi.OutputState }

func (LookupMetricResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupMetricResult)(nil)).Elem()
}

func (o LookupMetricResultOutput) ToLookupMetricResultOutput() LookupMetricResultOutput {
	return o
}

func (o LookupMetricResultOutput) ToLookupMetricResultOutputWithContext(ctx context.Context) LookupMetricResultOutput {
	return o
}

// The description of the metric's purpose.
func (o LookupMetricResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

// The event key to watch for `custom` metrics.
func (o LookupMetricResultOutput) EventKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *string { return v.EventKey }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupMetricResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMetricResult) string { return v.Id }).(pulumi.StringOutput)
}

// Whether a metric is a active.
func (o LookupMetricResultOutput) IsActive() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *bool { return v.IsActive }).(pulumi.BoolPtrOutput)
}

// Whether a `custom` metric is a numeric metric or not.
func (o LookupMetricResultOutput) IsNumeric() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *bool { return v.IsNumeric }).(pulumi.BoolPtrOutput)
}

func (o LookupMetricResultOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMetricResult) string { return v.Key }).(pulumi.StringOutput)
}

// The metric type. Available choices are `click`, `custom`, and `pageview`.
func (o LookupMetricResultOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

// The userId of the user maintaining the metric.
func (o LookupMetricResultOutput) MaintainerId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMetricResult) string { return v.MaintainerId }).(pulumi.StringOutput)
}

// The name of the metric.
func (o LookupMetricResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// The metrics's project key.
func (o LookupMetricResultOutput) ProjectKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupMetricResult) string { return v.ProjectKey }).(pulumi.StringOutput)
}

// A set of one or more context kinds that this metric can measure events from. Metrics can only use context kinds marked as "Available for experiments." For more information, read [Allocating experiment audiences](https://docs.launchdarkly.com/home/creating-experiments/allocation)
func (o LookupMetricResultOutput) RandomizationUnits() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupMetricResult) []string { return v.RandomizationUnits }).(pulumi.StringArrayOutput)
}

// The CSS selector for `click` metrics.
func (o LookupMetricResultOutput) Selector() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *string { return v.Selector }).(pulumi.StringPtrOutput)
}

// The success criteria for numeric `custom` metrics.
func (o LookupMetricResultOutput) SuccessCriteria() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *string { return v.SuccessCriteria }).(pulumi.StringPtrOutput)
}

// Set of tags associated with the metric.
func (o LookupMetricResultOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupMetricResult) []string { return v.Tags }).(pulumi.StringArrayOutput)
}

// The unit for numeric `custom` metrics.
func (o LookupMetricResultOutput) Unit() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupMetricResult) *string { return v.Unit }).(pulumi.StringPtrOutput)
}

// Which URLs the metric watches.
func (o LookupMetricResultOutput) Urls() GetMetricUrlArrayOutput {
	return o.ApplyT(func(v LookupMetricResult) []GetMetricUrl { return v.Urls }).(GetMetricUrlArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupMetricResultOutput{})
}
