// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package launchdarkly

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-launchdarkly/sdk/go/launchdarkly/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a LaunchDarkly team members data source.
//
// This data source allows you to retrieve team member information from your LaunchDarkly organization on multiple team members.
func GetTeamMembers(ctx *pulumi.Context, args *GetTeamMembersArgs, opts ...pulumi.InvokeOption) (*GetTeamMembersResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetTeamMembersResult
	err := ctx.Invoke("launchdarkly:index/getTeamMembers:getTeamMembers", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTeamMembers.
type GetTeamMembersArgs struct {
	// An array of unique email addresses associated with the team members.
	Emails []string `pulumi:"emails"`
	// A boolean to determine whether to ignore members that weren't found.
	IgnoreMissing *bool `pulumi:"ignoreMissing"`
}

// A collection of values returned by getTeamMembers.
type GetTeamMembersResult struct {
	Emails []string `pulumi:"emails"`
	// The provider-assigned unique ID for this managed resource.
	Id            string                     `pulumi:"id"`
	IgnoreMissing *bool                      `pulumi:"ignoreMissing"`
	TeamMembers   []GetTeamMembersTeamMember `pulumi:"teamMembers"`
}

func GetTeamMembersOutput(ctx *pulumi.Context, args GetTeamMembersOutputArgs, opts ...pulumi.InvokeOption) GetTeamMembersResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetTeamMembersResult, error) {
			args := v.(GetTeamMembersArgs)
			r, err := GetTeamMembers(ctx, &args, opts...)
			var s GetTeamMembersResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetTeamMembersResultOutput)
}

// A collection of arguments for invoking getTeamMembers.
type GetTeamMembersOutputArgs struct {
	// An array of unique email addresses associated with the team members.
	Emails pulumi.StringArrayInput `pulumi:"emails"`
	// A boolean to determine whether to ignore members that weren't found.
	IgnoreMissing pulumi.BoolPtrInput `pulumi:"ignoreMissing"`
}

func (GetTeamMembersOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTeamMembersArgs)(nil)).Elem()
}

// A collection of values returned by getTeamMembers.
type GetTeamMembersResultOutput struct{ *pulumi.OutputState }

func (GetTeamMembersResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTeamMembersResult)(nil)).Elem()
}

func (o GetTeamMembersResultOutput) ToGetTeamMembersResultOutput() GetTeamMembersResultOutput {
	return o
}

func (o GetTeamMembersResultOutput) ToGetTeamMembersResultOutputWithContext(ctx context.Context) GetTeamMembersResultOutput {
	return o
}

func (o GetTeamMembersResultOutput) Emails() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetTeamMembersResult) []string { return v.Emails }).(pulumi.StringArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetTeamMembersResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetTeamMembersResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetTeamMembersResultOutput) IgnoreMissing() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v GetTeamMembersResult) *bool { return v.IgnoreMissing }).(pulumi.BoolPtrOutput)
}

func (o GetTeamMembersResultOutput) TeamMembers() GetTeamMembersTeamMemberArrayOutput {
	return o.ApplyT(func(v GetTeamMembersResult) []GetTeamMembersTeamMember { return v.TeamMembers }).(GetTeamMembersTeamMemberArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetTeamMembersResultOutput{})
}