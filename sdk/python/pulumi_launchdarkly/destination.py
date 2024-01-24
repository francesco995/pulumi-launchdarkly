# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['DestinationArgs', 'Destination']

@pulumi.input_type
class DestinationArgs:
    def __init__(__self__, *,
                 config: pulumi.Input[Mapping[str, pulumi.Input[str]]],
                 env_key: pulumi.Input[str],
                 kind: pulumi.Input[str],
                 project_key: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None,
                 on: Optional[pulumi.Input[bool]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a Destination resource.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] config: The destination-specific configuration. To learn more, read Destination-Specific Configs
        :param pulumi.Input[str] env_key: The environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] kind: The data export destination type. Available choices are `kinesis`, `google-pubsub`, `mparticle`, `azure-event-hubs`, and `segment`. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] project_key: The LaunchDarkly project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] name: A human-readable name for your data export destination.
        :param pulumi.Input[bool] on: Whether the data export destination is on or not.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Tags associated with your resource.
        """
        pulumi.set(__self__, "config", config)
        pulumi.set(__self__, "env_key", env_key)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "project_key", project_key)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if on is not None:
            pulumi.set(__self__, "on", on)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def config(self) -> pulumi.Input[Mapping[str, pulumi.Input[str]]]:
        """
        The destination-specific configuration. To learn more, read Destination-Specific Configs
        """
        return pulumi.get(self, "config")

    @config.setter
    def config(self, value: pulumi.Input[Mapping[str, pulumi.Input[str]]]):
        pulumi.set(self, "config", value)

    @property
    @pulumi.getter(name="envKey")
    def env_key(self) -> pulumi.Input[str]:
        """
        The environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "env_key")

    @env_key.setter
    def env_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "env_key", value)

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Input[str]:
        """
        The data export destination type. Available choices are `kinesis`, `google-pubsub`, `mparticle`, `azure-event-hubs`, and `segment`. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "kind")

    @kind.setter
    def kind(self, value: pulumi.Input[str]):
        pulumi.set(self, "kind", value)

    @property
    @pulumi.getter(name="projectKey")
    def project_key(self) -> pulumi.Input[str]:
        """
        The LaunchDarkly project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "project_key")

    @project_key.setter
    def project_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_key", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        A human-readable name for your data export destination.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def on(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the data export destination is on or not.
        """
        return pulumi.get(self, "on")

    @on.setter
    def on(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "on", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Tags associated with your resource.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)


@pulumi.input_type
class _DestinationState:
    def __init__(__self__, *,
                 config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 env_key: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 on: Optional[pulumi.Input[bool]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering Destination resources.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] config: The destination-specific configuration. To learn more, read Destination-Specific Configs
        :param pulumi.Input[str] env_key: The environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] kind: The data export destination type. Available choices are `kinesis`, `google-pubsub`, `mparticle`, `azure-event-hubs`, and `segment`. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] name: A human-readable name for your data export destination.
        :param pulumi.Input[bool] on: Whether the data export destination is on or not.
        :param pulumi.Input[str] project_key: The LaunchDarkly project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Tags associated with your resource.
        """
        if config is not None:
            pulumi.set(__self__, "config", config)
        if env_key is not None:
            pulumi.set(__self__, "env_key", env_key)
        if kind is not None:
            pulumi.set(__self__, "kind", kind)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if on is not None:
            pulumi.set(__self__, "on", on)
        if project_key is not None:
            pulumi.set(__self__, "project_key", project_key)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def config(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        The destination-specific configuration. To learn more, read Destination-Specific Configs
        """
        return pulumi.get(self, "config")

    @config.setter
    def config(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "config", value)

    @property
    @pulumi.getter(name="envKey")
    def env_key(self) -> Optional[pulumi.Input[str]]:
        """
        The environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "env_key")

    @env_key.setter
    def env_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "env_key", value)

    @property
    @pulumi.getter
    def kind(self) -> Optional[pulumi.Input[str]]:
        """
        The data export destination type. Available choices are `kinesis`, `google-pubsub`, `mparticle`, `azure-event-hubs`, and `segment`. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "kind")

    @kind.setter
    def kind(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "kind", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        A human-readable name for your data export destination.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def on(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the data export destination is on or not.
        """
        return pulumi.get(self, "on")

    @on.setter
    def on(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "on", value)

    @property
    @pulumi.getter(name="projectKey")
    def project_key(self) -> Optional[pulumi.Input[str]]:
        """
        The LaunchDarkly project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "project_key")

    @project_key.setter
    def project_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_key", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Tags associated with your resource.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "tags", value)


class Destination(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 env_key: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 on: Optional[pulumi.Input[bool]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Provides a LaunchDarkly Data Export Destination resource.

        > **Note:** Data Export is available to customers on an Enterprise LaunchDarkly plan. To learn more, read about our pricing. To upgrade your plan, [contact LaunchDarkly Sales](https://launchdarkly.com/contact-sales/).

        Data Export Destinations are locations that receive exported data. This resource allows you to configure destinations for the export of raw analytics data, including feature flag requests, analytics events, custom events, and more.

        To learn more about data export, read [Data Export Documentation](https://docs.launchdarkly.com/integrations/data-export).

        ## Example Usage

        ```python
        import pulumi
        import json
        import pulumi_launchdarkly as launchdarkly

        # Currently the following five types of destinations are available: kinesis, google-pubsub, mparticle, azure-event-hubs, and segment. Please note that config fields will vary depending on which destination you are trying to configure / access.
        kinesis_example = launchdarkly.Destination("kinesisExample",
            project_key="example-project",
            env_key="example-env",
            kind="kinesis",
            config={
                "region": "us-east-1",
                "role_arn": "arn:aws:iam::123456789012:role/marketingadmin",
                "stream_name": "cat-stream",
            },
            on=True,
            tags=["terraform"])
        pubsub_example = launchdarkly.Destination("pubsubExample",
            project_key="example-project",
            env_key="example-env",
            kind="google-pubsub",
            config={
                "project": "example-pub-sub-project",
                "topic": "example-topic",
            },
            on=True,
            tags=["terraform"])
        mparticle_example = launchdarkly.Destination("mparticleExample",
            project_key="example-project",
            env_key="example-env",
            kind="mparticle",
            config={
                "api_key": "apiKeyfromMParticle",
                "secret": "mParticleSecret",
                "user_identities": json.dumps([
                    {
                        "ldContextKind": "user",
                        "mparticleUserIdentity": "customer_id",
                    },
                    {
                        "ldContextKind": "device",
                        "mparticleUserIdentity": "google",
                    },
                ]),
                "environment": "production",
            },
            on=True,
            tags=["terraform"])
        azure_example = launchdarkly.Destination("azureExample",
            project_key="example-project",
            env_key="example-env",
            kind="azure-event-hubs",
            config={
                "namespace": "example-azure-namespace",
                "name": "example-azure-name",
                "policy_name": "example-policy-name",
                "policy_key": "azure-event-hubs-policy-key",
            },
            on=True,
            tags=["terraform"])
        segment_example = launchdarkly.Destination("segmentExample",
            project_key="example-project",
            env_key="example-env",
            kind="segment",
            config={
                "write_key": "segment-write-key",
                "user_id_context_kind": "user",
                "anonymous_id_context_kind": "anonymousUser",
            },
            on=True,
            tags=["terraform"])
        ```

        ## Import

        You can import a data export destination using the destination's full ID in the format `project_key/environment_key/id`. For example

        ```sh
         $ pulumi import launchdarkly:index/destination:Destination example example-project/example-env/57c0af609969090743529967
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] config: The destination-specific configuration. To learn more, read Destination-Specific Configs
        :param pulumi.Input[str] env_key: The environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] kind: The data export destination type. Available choices are `kinesis`, `google-pubsub`, `mparticle`, `azure-event-hubs`, and `segment`. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] name: A human-readable name for your data export destination.
        :param pulumi.Input[bool] on: Whether the data export destination is on or not.
        :param pulumi.Input[str] project_key: The LaunchDarkly project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Tags associated with your resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DestinationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a LaunchDarkly Data Export Destination resource.

        > **Note:** Data Export is available to customers on an Enterprise LaunchDarkly plan. To learn more, read about our pricing. To upgrade your plan, [contact LaunchDarkly Sales](https://launchdarkly.com/contact-sales/).

        Data Export Destinations are locations that receive exported data. This resource allows you to configure destinations for the export of raw analytics data, including feature flag requests, analytics events, custom events, and more.

        To learn more about data export, read [Data Export Documentation](https://docs.launchdarkly.com/integrations/data-export).

        ## Example Usage

        ```python
        import pulumi
        import json
        import pulumi_launchdarkly as launchdarkly

        # Currently the following five types of destinations are available: kinesis, google-pubsub, mparticle, azure-event-hubs, and segment. Please note that config fields will vary depending on which destination you are trying to configure / access.
        kinesis_example = launchdarkly.Destination("kinesisExample",
            project_key="example-project",
            env_key="example-env",
            kind="kinesis",
            config={
                "region": "us-east-1",
                "role_arn": "arn:aws:iam::123456789012:role/marketingadmin",
                "stream_name": "cat-stream",
            },
            on=True,
            tags=["terraform"])
        pubsub_example = launchdarkly.Destination("pubsubExample",
            project_key="example-project",
            env_key="example-env",
            kind="google-pubsub",
            config={
                "project": "example-pub-sub-project",
                "topic": "example-topic",
            },
            on=True,
            tags=["terraform"])
        mparticle_example = launchdarkly.Destination("mparticleExample",
            project_key="example-project",
            env_key="example-env",
            kind="mparticle",
            config={
                "api_key": "apiKeyfromMParticle",
                "secret": "mParticleSecret",
                "user_identities": json.dumps([
                    {
                        "ldContextKind": "user",
                        "mparticleUserIdentity": "customer_id",
                    },
                    {
                        "ldContextKind": "device",
                        "mparticleUserIdentity": "google",
                    },
                ]),
                "environment": "production",
            },
            on=True,
            tags=["terraform"])
        azure_example = launchdarkly.Destination("azureExample",
            project_key="example-project",
            env_key="example-env",
            kind="azure-event-hubs",
            config={
                "namespace": "example-azure-namespace",
                "name": "example-azure-name",
                "policy_name": "example-policy-name",
                "policy_key": "azure-event-hubs-policy-key",
            },
            on=True,
            tags=["terraform"])
        segment_example = launchdarkly.Destination("segmentExample",
            project_key="example-project",
            env_key="example-env",
            kind="segment",
            config={
                "write_key": "segment-write-key",
                "user_id_context_kind": "user",
                "anonymous_id_context_kind": "anonymousUser",
            },
            on=True,
            tags=["terraform"])
        ```

        ## Import

        You can import a data export destination using the destination's full ID in the format `project_key/environment_key/id`. For example

        ```sh
         $ pulumi import launchdarkly:index/destination:Destination example example-project/example-env/57c0af609969090743529967
        ```

        :param str resource_name: The name of the resource.
        :param DestinationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DestinationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 env_key: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 on: Optional[pulumi.Input[bool]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DestinationArgs.__new__(DestinationArgs)

            if config is None and not opts.urn:
                raise TypeError("Missing required property 'config'")
            __props__.__dict__["config"] = config
            if env_key is None and not opts.urn:
                raise TypeError("Missing required property 'env_key'")
            __props__.__dict__["env_key"] = env_key
            if kind is None and not opts.urn:
                raise TypeError("Missing required property 'kind'")
            __props__.__dict__["kind"] = kind
            __props__.__dict__["name"] = name
            __props__.__dict__["on"] = on
            if project_key is None and not opts.urn:
                raise TypeError("Missing required property 'project_key'")
            __props__.__dict__["project_key"] = project_key
            __props__.__dict__["tags"] = tags
        super(Destination, __self__).__init__(
            'launchdarkly:index/destination:Destination',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            env_key: Optional[pulumi.Input[str]] = None,
            kind: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            on: Optional[pulumi.Input[bool]] = None,
            project_key: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'Destination':
        """
        Get an existing Destination resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] config: The destination-specific configuration. To learn more, read Destination-Specific Configs
        :param pulumi.Input[str] env_key: The environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] kind: The data export destination type. Available choices are `kinesis`, `google-pubsub`, `mparticle`, `azure-event-hubs`, and `segment`. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[str] name: A human-readable name for your data export destination.
        :param pulumi.Input[bool] on: Whether the data export destination is on or not.
        :param pulumi.Input[str] project_key: The LaunchDarkly project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] tags: Tags associated with your resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DestinationState.__new__(_DestinationState)

        __props__.__dict__["config"] = config
        __props__.__dict__["env_key"] = env_key
        __props__.__dict__["kind"] = kind
        __props__.__dict__["name"] = name
        __props__.__dict__["on"] = on
        __props__.__dict__["project_key"] = project_key
        __props__.__dict__["tags"] = tags
        return Destination(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def config(self) -> pulumi.Output[Mapping[str, str]]:
        """
        The destination-specific configuration. To learn more, read Destination-Specific Configs
        """
        return pulumi.get(self, "config")

    @property
    @pulumi.getter(name="envKey")
    def env_key(self) -> pulumi.Output[str]:
        """
        The environment key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "env_key")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[str]:
        """
        The data export destination type. Available choices are `kinesis`, `google-pubsub`, `mparticle`, `azure-event-hubs`, and `segment`. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        A human-readable name for your data export destination.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def on(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether the data export destination is on or not.
        """
        return pulumi.get(self, "on")

    @property
    @pulumi.getter(name="projectKey")
    def project_key(self) -> pulumi.Output[str]:
        """
        The LaunchDarkly project key. A change in this field will force the destruction of the existing resource and the creation of a new one.
        """
        return pulumi.get(self, "project_key")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Tags associated with your resource.
        """
        return pulumi.get(self, "tags")
