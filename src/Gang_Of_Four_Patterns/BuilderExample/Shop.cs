// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
using BuilderExample.Builders;

namespace BuilderExample;

/// <summary>
///     The "Director" class
/// </summary>
public record Shop
{
    private VehicleBuilder _vehicleBuilder;

    public void Build(VehicleBuilder vehicleBuilder)
    {
        ArgumentNullException.ThrowIfNull(vehicleBuilder);
        _vehicleBuilder = vehicleBuilder;

        _vehicleBuilder.BuildFrame();
        _vehicleBuilder.BuildEngine();
        _vehicleBuilder.BuildWheels();
        _vehicleBuilder.BuildDoors();
    }
}
