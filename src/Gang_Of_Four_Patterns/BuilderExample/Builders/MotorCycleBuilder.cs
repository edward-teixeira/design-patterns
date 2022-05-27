// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace BuilderExample.Builders;

/// <summary>
///     The "ConcreteBuilder" class
/// </summary>
public class MotorCycleBuilder : VehicleBuilder
{
    public MotorCycleBuilder() : base(VehicleType.MotorCycle)
    {
    }

    public override void BuildFrame()
    {
        Vehicle[PartType.Frame] = "MotorCycle Frame";
    }

    public override void BuildEngine()
    {
        Vehicle[PartType.Engine] = "500 cc";
    }

    public override void BuildWheels()
    {
        Vehicle[PartType.Wheel] = "4";
    }

    public override void BuildDoors()
    {
        Vehicle[PartType.Door] = "4";
    }
}
