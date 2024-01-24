// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package launchdarkly

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-launchdarkly/sdk/go/launchdarkly/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

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
//			_, err := launchdarkly.NewRelayProxyConfiguration(ctx, "example", &launchdarkly.RelayProxyConfigurationArgs{
//				Policies: launchdarkly.RelayProxyConfigurationPolicyArray{
//					&launchdarkly.RelayProxyConfigurationPolicyArgs{
//						Actions: pulumi.StringArray{
//							pulumi.String("*"),
//						},
//						Effect: pulumi.String("allow"),
//						Resources: pulumi.StringArray{
//							pulumi.String("proj/*:env/*"),
//						},
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupRelayProxyConfiguration(ctx *pulumi.Context, args *LookupRelayProxyConfigurationArgs, opts ...pulumi.InvokeOption) (*LookupRelayProxyConfigurationResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupRelayProxyConfigurationResult
	err := ctx.Invoke("launchdarkly:index/getRelayProxyConfiguration:getRelayProxyConfiguration", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRelayProxyConfiguration.
type LookupRelayProxyConfigurationArgs struct {
	// The Relay Proxy configuration's unique 24 character ID. The unique relay proxy ID can be found in the relay proxy edit page URL, which you can locate by clicking the three dot menu on your relay proxy item in the UI and selecting 'Edit configuration':
	//
	// ```go
	// package main
	//
	// import (
	// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	// )
	//
	// func main() {
	// 	pulumi.Run(func(ctx *pulumi.Context) error {
	// 		return nil
	// 	})
	// }
	// ```
	Id string `pulumi:"id"`
}

// A collection of values returned by getRelayProxyConfiguration.
type LookupRelayProxyConfigurationResult struct {
	// The last 4 characters of the Relay Proxy configuration's unique key.
	DisplayKey string `pulumi:"displayKey"`
	Id         string `pulumi:"id"`
	// The human-readable name for your Relay Proxy configuration.
	Name string `pulumi:"name"`
	// The Relay Proxy configuration's rule policy block. This determines what content the Relay Proxy receives. To learn more, read [Understanding policies](https://docs.launchdarkly.com/home/members/role-policies#understanding-policies).
	Policies []GetRelayProxyConfigurationPolicy `pulumi:"policies"`
}

func LookupRelayProxyConfigurationOutput(ctx *pulumi.Context, args LookupRelayProxyConfigurationOutputArgs, opts ...pulumi.InvokeOption) LookupRelayProxyConfigurationResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupRelayProxyConfigurationResult, error) {
			args := v.(LookupRelayProxyConfigurationArgs)
			r, err := LookupRelayProxyConfiguration(ctx, &args, opts...)
			var s LookupRelayProxyConfigurationResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupRelayProxyConfigurationResultOutput)
}

// A collection of arguments for invoking getRelayProxyConfiguration.
type LookupRelayProxyConfigurationOutputArgs struct {
	// The Relay Proxy configuration's unique 24 character ID. The unique relay proxy ID can be found in the relay proxy edit page URL, which you can locate by clicking the three dot menu on your relay proxy item in the UI and selecting 'Edit configuration':
	//
	// ```go
	// package main
	//
	// import (
	// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	// )
	//
	// func main() {
	// 	pulumi.Run(func(ctx *pulumi.Context) error {
	// 		return nil
	// 	})
	// }
	// ```
	Id pulumi.StringInput `pulumi:"id"`
}

func (LookupRelayProxyConfigurationOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRelayProxyConfigurationArgs)(nil)).Elem()
}

// A collection of values returned by getRelayProxyConfiguration.
type LookupRelayProxyConfigurationResultOutput struct{ *pulumi.OutputState }

func (LookupRelayProxyConfigurationResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRelayProxyConfigurationResult)(nil)).Elem()
}

func (o LookupRelayProxyConfigurationResultOutput) ToLookupRelayProxyConfigurationResultOutput() LookupRelayProxyConfigurationResultOutput {
	return o
}

func (o LookupRelayProxyConfigurationResultOutput) ToLookupRelayProxyConfigurationResultOutputWithContext(ctx context.Context) LookupRelayProxyConfigurationResultOutput {
	return o
}

// The last 4 characters of the Relay Proxy configuration's unique key.
func (o LookupRelayProxyConfigurationResultOutput) DisplayKey() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRelayProxyConfigurationResult) string { return v.DisplayKey }).(pulumi.StringOutput)
}

func (o LookupRelayProxyConfigurationResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRelayProxyConfigurationResult) string { return v.Id }).(pulumi.StringOutput)
}

// The human-readable name for your Relay Proxy configuration.
func (o LookupRelayProxyConfigurationResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRelayProxyConfigurationResult) string { return v.Name }).(pulumi.StringOutput)
}

// The Relay Proxy configuration's rule policy block. This determines what content the Relay Proxy receives. To learn more, read [Understanding policies](https://docs.launchdarkly.com/home/members/role-policies#understanding-policies).
func (o LookupRelayProxyConfigurationResultOutput) Policies() GetRelayProxyConfigurationPolicyArrayOutput {
	return o.ApplyT(func(v LookupRelayProxyConfigurationResult) []GetRelayProxyConfigurationPolicy { return v.Policies }).(GetRelayProxyConfigurationPolicyArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupRelayProxyConfigurationResultOutput{})
}