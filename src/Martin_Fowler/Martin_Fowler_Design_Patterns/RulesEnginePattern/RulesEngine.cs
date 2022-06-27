// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace RulesEnginePattern;

/// <summary>
///     Rule interface
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRule<in T>
{
    void Evaluate(T context);
}

/// <summary>
///     Concrete Implementation
/// </summary>
/// <typeparam name="T"></typeparam>
public class Rule<T> : IRule<T>
{
    private readonly Predicate<T> _condition;

    public Rule(Predicate<T> condition)
    {
        _condition = condition;
    }

    public void Evaluate(T context)
    {
        if (!_condition(context))
        {
            Console.WriteLine("Provided data didn't pass the rule condition!");
        }
    }
}

/// <summary>
///     The Rules Engine class
/// </summary>
/// <typeparam name="T"></typeparam>
public class RulesEngine<T>
{
    private readonly IEnumerable<IRule<T>> _rules = new List<Rule<T>>();

    public void AddRule(IRule<T> rule)
    {
        _rules.Append(rule);
    }

    public void Run(T data)
    {
        foreach (var rule in _rules)
        {
            rule.Evaluate(data);
        }
    }
}
