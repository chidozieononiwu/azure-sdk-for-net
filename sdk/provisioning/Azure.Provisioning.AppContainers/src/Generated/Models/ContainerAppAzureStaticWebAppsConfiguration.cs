// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the Azure Static Web Apps provider.
/// </summary>
public partial class ContainerAppAzureStaticWebAppsConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider
    /// should not be enabled despite the set registration; otherwise,
    /// &lt;code&gt;true&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// The Client ID of the app used for login.
    /// </summary>
    public BicepValue<string> RegistrationClientId 
    {
        get { Initialize(); return _registrationClientId!; }
        set { Initialize(); _registrationClientId!.Assign(value); }
    }
    private BicepValue<string>? _registrationClientId;

    /// <summary>
    /// Creates a new ContainerAppAzureStaticWebAppsConfiguration.
    /// </summary>
    public ContainerAppAzureStaticWebAppsConfiguration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppAzureStaticWebAppsConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isEnabled = DefineProperty<bool>("IsEnabled", ["enabled"]);
        _registrationClientId = DefineProperty<string>("RegistrationClientId", ["registration", "clientId"]);
    }
}
