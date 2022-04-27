// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace BuilderExample.Models;

/// <summary>
///     The "Product" class
/// </summary>
public record Vehicle(VehicleType VehicleType)
{
    private readonly Dictionary<PartType, string> _parts = new();

    public string this[PartType key]
    {
        get => _parts[key];
        set => _parts[key] = value;
    }

    public void Show()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine("Vehicle Type: {0}", VehicleType);
        Console.WriteLine(" Frame  : {0}",
            this[PartType.Frame]);
        Console.WriteLine(" Engine : {0}",
            this[PartType.Engine]);
        Console.WriteLine(" #Wheels: {0}",
            this[PartType.Wheel]);
        Console.WriteLine(" #Doors : {0}",
            this[PartType.Door]);
    }
}
