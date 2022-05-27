using BuilderStructure.Interfaces;

namespace BuilderStructure;

/// <summary>
///     The Director class defines the order in which to call construc-
///     tion steps, so you can create and reuse specific configurations
///     of products.
/// </summary>
public class Director
{
    private IBuilder _builder;

    public void Build(IBuilder builder)
    {
        _builder = builder;

        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}
