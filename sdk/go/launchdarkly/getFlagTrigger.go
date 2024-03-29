// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package launchdarkly

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-launchdarkly/sdk/go/launchdarkly/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a LaunchDarkly flag trigger data source.
//
// > **Note:** Flag triggers are available to customers on an Enterprise LaunchDarkly plan. To learn more, read about our pricing. To upgrade your plan, [contact LaunchDarkly Sales](https://launchdarkly.com/contact-sales/).
//
// This data source allows you to retrieve information about flag triggers from your LaunchDarkly organization.
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
//			_, err := launchdarkly.LookupFlagTrigger(ctx, &launchdarkly.LookupFlagTriggerArgs{
//				Id: "<project_key>/<env_key>/<flag_key>/61d490757f7821150815518f",
//				Instructions: launchdarkly.GetFlagTriggerInstructions{
//					Kind: "turnFlagOff",
//				},
//				IntegrationKey: pulumi.StringRef("datadog"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupFlagTrigger(ctx *pulumi.Context, args *LookupFlagTriggerArgs, opts ...pulumi.InvokeOption) (*LookupFlagTriggerResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupFlagTriggerResult
	err := ctx.Invoke("launchdarkly:index/getFlagTrigger:getFlagTrigger", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFlagTrigger.
type LookupFlagTriggerArgs struct {
	// Whether the trigger is currently active or not.
	Enabled *bool `pulumi:"enabled"`
	// The unique key of the environment the flag trigger will work in.
	EnvKey string `pulumi:"envKey"`
	// The unique key of the associated flag.
	FlagKey string `pulumi:"flagKey"`
	Id      string `pulumi:"id"`
	// Instructions containing the action to perform when invoking the trigger. Currently supported flag actions are `"turnFlagOn"` and `"turnFlagOff"`. These can be found on the `kind` field nested on the `instructions` attribute.
	Instructions *GetFlagTriggerInstructions `pulumi:"instructions"`
	// The unique identifier of the integration your trigger is set up with.
	IntegrationKey *string `pulumi:"integrationKey"`
	// The unique key of the project encompassing the associated flag.
	ProjectKey string `pulumi:"projectKey"`
}

// A collection of values returned by getFlagTrigger.
type LookupFlagTriggerResult struct {
	// Whether the trigger is currently active or not.
	Enabled *bool `pulumi:"enabled"`
	// The unique key of the environment the flag trigger will work in.
	EnvKey string `pulumi:"envKey"`
	// The unique key of the associated flag.
	FlagKey string `pulumi:"flagKey"`
	Id      string `pulumi:"id"`
	// Instructions containing the action to perform when invoking the trigger. Currently supported flag actions are `"turnFlagOn"` and `"turnFlagOff"`. These can be found on the `kind` field nested on the `instructions` attribute.
	Instructions *GetFlagTriggerInstructions `pulumi:"instructions"`
	// The unique identifier of the integration your trigger is set up with.
	IntegrationKey *string `pulumi:"integrationKey"`
	MaintainerId   string  `pulumi:"maintainerId"`
	// The unique key of the project encompassing the associated flag.
	ProjectKey string `pulumi:"projectKey"`
	TriggerUrl string `pulumi:"triggerUrl"`
}

func LookupFlagTriggerOutput(ctx *pulumi.Context, args LookupFlagTriggerOutputArgs, opts ...pulumi.InvokeOption) LookupFlagTriggerResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupFlagTriggerResult, error) {
			args := v.(LookupFlagTriggerArgs)
			r, err := LookupFlagTrigger(ctx, &args, opts...)
			var s LookupFlagTriggerResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupFlagTriggerResultOutput)
}

// A collection of arguments for invoking getFlagTrigger.
type LookupFlagTriggerOutputArgs struct {
	// Whether the trigger is currently active or not.
	Enabled pulumi.BoolPtrInput `pulumi:"enabled"`
	// The unique key of the environment the flag trigger will work in.
	EnvKey pulumi.StringInput `pulumi:"envKey"`
	// The unique key of the associated flag.
	FlagKey pulumi.StringInput `pulumi:"flagKey"`
	Id      pulumi.StringInput `pulumi:"id"`
	// Instructions containing the action to perform when invoking the trigger. Currently supported flag actions are `"turnFlagOn"` and `"turnFlagOff"`. These can be found on the `kind` field nested on the `instructions` attribute.
	Instructions GetFlagTriggerInstructionsPtrInput `pulumi:"instructions"`
	// The unique identifier of the integration your trigger is set up with.
	IntegrationKey pulumi.StringPtrInput `pulumi:"integrationKey"`
	// The unique key of the project encompassing the associated flag.
	ProjectKey pulumi.StringInput `pulumi:"projectKey"`
}

func (LookupFlagTriggerOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupFlagTriggerArgs)(nil)).Elem()
}

// A collection of values returned by getFlagTrigger.
type LookupFlagTriggerResultOutput struct{ *pulumi.OutputState }

func (LookupFlagTriggerResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupFlagTriggerResult)(nil)).Elem()
}

func (o LookupFlagTriggerResultOutput) ToLookupFlagTriggerResultOutput() LookupFlagTriggerResultOutput {
	return o
}

func (o LookupFlagTriggerResultOutput) ToLookupFlagTriggerResultOutputWithContext(ctx context.Context) LookupFlagTriggerResultOutput {
	return o
}

// Whether the trigger is currently active or not.
func (o LookupFlagTriggerResultOutput) Enabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) *bool { return v.Enabled }).(pulumi.BoolPtrOutput)
}

// The unique key of the environment the flag trigger will work in.
func (o LookupFlagTriggerResultOutput) EnvKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) string { return v.EnvKey }).(pulumi.StringOutput)
}

// The unique key of the associated flag.
func (o LookupFlagTriggerResultOutput) FlagKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) string { return v.FlagKey }).(pulumi.StringOutput)
}

func (o LookupFlagTriggerResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) string { return v.Id }).(pulumi.StringOutput)
}

// Instructions containing the action to perform when invoking the trigger. Currently supported flag actions are `"turnFlagOn"` and `"turnFlagOff"`. These can be found on the `kind` field nested on the `instructions` attribute.
func (o LookupFlagTriggerResultOutput) Instructions() GetFlagTriggerInstructionsPtrOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) *GetFlagTriggerInstructions { return v.Instructions }).(GetFlagTriggerInstructionsPtrOutput)
}

// The unique identifier of the integration your trigger is set up with.
func (o LookupFlagTriggerResultOutput) IntegrationKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) *string { return v.IntegrationKey }).(pulumi.StringPtrOutput)
}

func (o LookupFlagTriggerResultOutput) MaintainerId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) string { return v.MaintainerId }).(pulumi.StringOutput)
}

// The unique key of the project encompassing the associated flag.
func (o LookupFlagTriggerResultOutput) ProjectKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) string { return v.ProjectKey }).(pulumi.StringOutput)
}

func (o LookupFlagTriggerResultOutput) TriggerUrl() pulumi.StringOutput {
	return o.ApplyT(func(v LookupFlagTriggerResult) string { return v.TriggerUrl }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupFlagTriggerResultOutput{})
}
