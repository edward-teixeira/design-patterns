namespace NullObjectPattern;

internal class PlayerCharacter
{
    private readonly SpecialDefence _specialDefence;

    public PlayerCharacter(SpecialDefence specialDefence) => this._specialDefence = specialDefence;

    public string Name { get; set; }
    public int Health { get; private set; } = 100;

    public void Hit(int damage)
    {
        var damageReduction = 0;

        damageReduction = this._specialDefence.CalculateDamageReduction();

        var totalDamageTaken = Math.Abs(damage - damageReduction);

        this.Health -= totalDamageTaken;

        Console.WriteLine($"{this.Name}'s health has been reduced by {totalDamageTaken} to {this.Health}.");
    }
}
