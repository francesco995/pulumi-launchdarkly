// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package launchdarkly

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-launchdarkly/sdk/go/launchdarkly/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a LaunchDarkly environment data source.
//
// This data source allows you to retrieve environment information from your LaunchDarkly organization.
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
//			_, err := launchdarkly.LookupEnvironment(ctx, &launchdarkly.LookupEnvironmentArgs{
//				Key:        "example-env",
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
func LookupEnvironment(ctx *pulumi.Context, args *LookupEnvironmentArgs, opts ...pulumi.InvokeOption) (*LookupEnvironmentResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupEnvironmentResult
	err := ctx.Invoke("launchdarkly:index/getEnvironment:getEnvironment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getEnvironment.
type LookupEnvironmentArgs struct {
	// The project-unique key for the environment.
	Key string `pulumi:"key"`
	// The environment's project key.
	ProjectKey string `pulumi:"projectKey"`
}

// A collection of values returned by getEnvironment.
type LookupEnvironmentResult struct {
	// The environment's SDK key.
	ApiKey           string                          `pulumi:"apiKey"`
	ApprovalSettings []GetEnvironmentApprovalSetting `pulumi:"approvalSettings"`
	// The environment's client-side ID.
	ClientSideId string `pulumi:"clientSideId"`
	Color        string `pulumi:"color"`
	// Set to `true` if this environment requires confirmation for flag and segment changes. This field will default to `false` when not set.
	ConfirmChanges bool `pulumi:"confirmChanges"`
	// Set to `true` to enable data export for every flag created in this environment after you configure this argument. This field will default to `false` when not set. To learn more, read [Data Export](https://docs.launchdarkly.com/home/data-export).
	DefaultTrackEvents bool `pulumi:"defaultTrackEvents"`
	// The TTL for the environment. This must be between 0 and 60 minutes. The TTL setting only applies to environments using the PHP SDK. This field will default to `0` when not set. To learn more, read [TTL settings](https://docs.launchdarkly.com/home/organize/environments#ttl-settings).
	DefaultTtl int `pulumi:"defaultTtl"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The project-unique key for the environment.
	Key string `pulumi:"key"`
	// The environment's mobile key.
	MobileKey string `pulumi:"mobileKey"`
	Name      string `pulumi:"name"`
	// The environment's project key.
	ProjectKey string `pulumi:"projectKey"`
	// Set to `true` if this environment requires comments for flag and segment changes. This field will default to `false` when not set.
	RequireComments bool `pulumi:"requireComments"`
	// Set to `true` to ensure a user of the client-side SDK cannot impersonate another user. This field will default to `false` when not set.
	SecureMode bool `pulumi:"secureMode"`
	// Tags associated with your resource.
	Tags []string `pulumi:"tags"`
}

func LookupEnvironmentOutput(ctx *pulumi.Context, args LookupEnvironmentOutputArgs, opts ...pulumi.InvokeOption) LookupEnvironmentResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupEnvironmentResult, error) {
			args := v.(LookupEnvironmentArgs)
			r, err := LookupEnvironment(ctx, &args, opts...)
			var s LookupEnvironmentResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupEnvironmentResultOutput)
}

// A collection of arguments for invoking getEnvironment.
type LookupEnvironmentOutputArgs struct {
	// The project-unique key for the environment.
	Key pulumi.StringInput `pulumi:"key"`
	// The environment's project key.
	ProjectKey pulumi.StringInput `pulumi:"projectKey"`
}

func (LookupEnvironmentOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupEnvironmentArgs)(nil)).Elem()
}

// A collection of values returned by getEnvironment.
type LookupEnvironmentResultOutput struct{ *pulumi.OutputState }

func (LookupEnvironmentResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupEnvironmentResult)(nil)).Elem()
}

func (o LookupEnvironmentResultOutput) ToLookupEnvironmentResultOutput() LookupEnvironmentResultOutput {
	return o
}

func (o LookupEnvironmentResultOutput) ToLookupEnvironmentResultOutputWithContext(ctx context.Context) LookupEnvironmentResultOutput {
	return o
}

// The environment's SDK key.
func (o LookupEnvironmentResultOutput) ApiKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) string { return v.ApiKey }).(pulumi.StringOutput)
}

func (o LookupEnvironmentResultOutput) ApprovalSettings() GetEnvironmentApprovalSettingArrayOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) []GetEnvironmentApprovalSetting { return v.ApprovalSettings }).(GetEnvironmentApprovalSettingArrayOutput)
}

// The environment's client-side ID.
func (o LookupEnvironmentResultOutput) ClientSideId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) string { return v.ClientSideId }).(pulumi.StringOutput)
}

func (o LookupEnvironmentResultOutput) Color() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) string { return v.Color }).(pulumi.StringOutput)
}

// Set to `true` if this environment requires confirmation for flag and segment changes. This field will default to `false` when not set.
func (o LookupEnvironmentResultOutput) ConfirmChanges() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) bool { return v.ConfirmChanges }).(pulumi.BoolOutput)
}

// Set to `true` to enable data export for every flag created in this environment after you configure this argument. This field will default to `false` when not set. To learn more, read [Data Export](https://docs.launchdarkly.com/home/data-export).
func (o LookupEnvironmentResultOutput) DefaultTrackEvents() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) bool { return v.DefaultTrackEvents }).(pulumi.BoolOutput)
}

// The TTL for the environment. This must be between 0 and 60 minutes. The TTL setting only applies to environments using the PHP SDK. This field will default to `0` when not set. To learn more, read [TTL settings](https://docs.launchdarkly.com/home/organize/environments#ttl-settings).
func (o LookupEnvironmentResultOutput) DefaultTtl() pulumi.IntOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) int { return v.DefaultTtl }).(pulumi.IntOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupEnvironmentResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) string { return v.Id }).(pulumi.StringOutput)
}

// The project-unique key for the environment.
func (o LookupEnvironmentResultOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) string { return v.Key }).(pulumi.StringOutput)
}

// The environment's mobile key.
func (o LookupEnvironmentResultOutput) MobileKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) string { return v.MobileKey }).(pulumi.StringOutput)
}

func (o LookupEnvironmentResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) string { return v.Name }).(pulumi.StringOutput)
}

// The environment's project key.
func (o LookupEnvironmentResultOutput) ProjectKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) string { return v.ProjectKey }).(pulumi.StringOutput)
}

// Set to `true` if this environment requires comments for flag and segment changes. This field will default to `false` when not set.
func (o LookupEnvironmentResultOutput) RequireComments() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) bool { return v.RequireComments }).(pulumi.BoolOutput)
}

// Set to `true` to ensure a user of the client-side SDK cannot impersonate another user. This field will default to `false` when not set.
func (o LookupEnvironmentResultOutput) SecureMode() pulumi.BoolOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) bool { return v.SecureMode }).(pulumi.BoolOutput)
}

// Tags associated with your resource.
func (o LookupEnvironmentResultOutput) Tags() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupEnvironmentResult) []string { return v.Tags }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupEnvironmentResultOutput{})
}
