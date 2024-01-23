module github.com/francesco995/pulumi-launchdarkly/provider

go 1.21

replace github.com/hashicorp/terraform-plugin-sdk/v2 => github.com/pulumi/terraform-plugin-sdk/v2 v2.0.0-20230912190043-e6d96b3b8f7e

require (
	github.com/launchdarkly/terraform-provider-launchdarkly 3bca36a0e280cb810143f527a1cbcc188e497ab3
	github.com/pulumi/pulumi-terraform-bridge/v3 v3.69.0
	github.com/pulumi/pulumi/sdk/v3 v3.98.0
)
