namespace NullObjectPattern;

public abstract class SpecialDefence
{
    public static SpecialDefence Null { get; } = new NullDefence();
    public abstract int CalculateDamageReduction();

    private class NullDefence : SpecialDefence
    {
        public override int CalculateDamageReduction() => 0; // "no op" or "do nothing" behavior
    }
}
