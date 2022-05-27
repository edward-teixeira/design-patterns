// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
using BuilderExample.Models;

namespace BuilderExample.Builders;

/// <summary>
///     The Builder class
/// </summary>
public abstract class VehicleBuilder
{
    private ICloneable _cloneableImplementation;

    protected VehicleBuilder(VehicleType vehicleType)
    {
        Vehicle = new Vehicle(vehicleType);
    }

    public Vehicle Vehicle { get; }
    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
}
