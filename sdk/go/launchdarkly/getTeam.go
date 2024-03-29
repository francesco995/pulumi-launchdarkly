// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package launchdarkly

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-launchdarkly/sdk/go/launchdarkly/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a LaunchDarkly team data source.
//
// This data source allows you to retrieve team information from your LaunchDarkly organization.
//
// > **Note:** Teams are available to customers on an Enterprise LaunchDarkly plan. To learn more, read about our pricing. To upgrade your plan, [contact LaunchDarkly Sales](https://launchdarkly.com/contact-sales/).
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
//			_, err := launchdarkly.LookupTeam(ctx, &launchdarkly.LookupTeamArgs{
//				Key: "platform_team",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
func LookupTeam(ctx *pulumi.Context, args *LookupTeamArgs, opts ...pulumi.InvokeOption) (*LookupTeamResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupTeamResult
	err := ctx.Invoke("launchdarkly:index/getTeam:getTeam", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTeam.
type LookupTeamArgs struct {
	// The list of the keys of the custom roles that you have assigned to the team.
	CustomRoleKeys []string `pulumi:"customRoleKeys"`
	// The team description.
	Description *string `pulumi:"description"`
	// The team key.
	Key string `pulumi:"key"`
	// Human readable name for the team.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getTeam.
type LookupTeamResult struct {
	// The list of the keys of the custom roles that you have assigned to the team.
	CustomRoleKeys []string `pulumi:"customRoleKeys"`
	// The team description.
	Description *string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id  string `pulumi:"id"`
	Key string `pulumi:"key"`
	// The list of team maintainers as [team member objects](https://www.terraform.io/docs/providers/launchdarkly/d/team_member.html).
	Maintainers []GetTeamMaintainer `pulumi:"maintainers"`
	// Human readable name for the team.
	Name *string `pulumi:"name"`
	// The list of keys of the projects that the team has any write access to.
	ProjectKeys []string `pulumi:"projectKeys"`
}

func LookupTeamOutput(ctx *pulumi.Context, args LookupTeamOutputArgs, opts ...pulumi.InvokeOption) LookupTeamResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupTeamResult, error) {
			args := v.(LookupTeamArgs)
			r, err := LookupTeam(ctx, &args, opts...)
			var s LookupTeamResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupTeamResultOutput)
}

// A collection of arguments for invoking getTeam.
type LookupTeamOutputArgs struct {
	// The list of the keys of the custom roles that you have assigned to the team.
	CustomRoleKeys pulumi.StringArrayInput `pulumi:"customRoleKeys"`
	// The team description.
	Description pulumi.StringPtrInput `pulumi:"description"`
	// The team key.
	Key pulumi.StringInput `pulumi:"key"`
	// Human readable name for the team.
	Name pulumi.StringPtrInput `pulumi:"name"`
}

func (LookupTeamOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTeamArgs)(nil)).Elem()
}

// A collection of values returned by getTeam.
type LookupTeamResultOutput struct{ *pulumi.OutputState }

func (LookupTeamResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTeamResult)(nil)).Elem()
}

func (o LookupTeamResultOutput) ToLookupTeamResultOutput() LookupTeamResultOutput {
	return o
}

func (o LookupTeamResultOutput) ToLookupTeamResultOutputWithContext(ctx context.Context) LookupTeamResultOutput {
	return o
}

// The list of the keys of the custom roles that you have assigned to the team.
func (o LookupTeamResultOutput) CustomRoleKeys() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupTeamResult) []string { return v.CustomRoleKeys }).(pulumi.StringArrayOutput)
}

// The team description.
func (o LookupTeamResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupTeamResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupTeamResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupTeamResultOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTeamResult) string { return v.Key }).(pulumi.StringOutput)
}

// The list of team maintainers as [team member objects](https://www.terraform.io/docs/providers/launchdarkly/d/team_member.html).
func (o LookupTeamResultOutput) Maintainers() GetTeamMaintainerArrayOutput {
	return o.ApplyT(func(v LookupTeamResult) []GetTeamMaintainer { return v.Maintainers }).(GetTeamMaintainerArrayOutput)
}

// Human readable name for the team.
func (o LookupTeamResultOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupTeamResult) *string { return v.Name }).(pulumi.StringPtrOutput)
}

// The list of keys of the projects that the team has any write access to.
func (o LookupTeamResultOutput) ProjectKeys() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupTeamResult) []string { return v.ProjectKeys }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupTeamResultOutput{})
}
