// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace ReplaceConstructorsWithCreationMethods;

/// <summary>
///     This example is inspired from the banking domain and a certain loan risk calculator.
///     The Loan class has numerous constructors.
/// </summary>
public class Loan
{
    private readonly CapitalStrategy _capitalStrategy;
    private readonly double _commitment;
    private readonly DateTime _expiry;
    private readonly DateTime _maturity;
    private readonly double _outstanding;
    private readonly int _riskRating;

    public Loan(double commitment, DateTime expiry, DateTime maturity, double outstanding, int riskRating)
    {
        _commitment = commitment;
        _expiry = expiry;
        _maturity = maturity;
        _outstanding = outstanding;
        _riskRating = riskRating;
    }

    public Loan(double commitment, int riskRating, DateTime maturity, DateTime expiry) :
        this(commitment, 0.00, riskRating, maturity, expiry) { }

    public Loan(double commitment, double outstanding,
        int riskRating, DateTime maturity, DateTime expiry) : this(null, commitment, outstanding, riskRating, maturity,
        expiry) { }

    public Loan(CapitalStrategy capitalStrategy, double commitment,
        int riskRating, DateTime maturity, DateTime expiry) : this(capitalStrategy, commitment, 0.00, riskRating,
        maturity, expiry) { }

    /// <summary>
    ///     Catch-all constructor
    /// </summary>
    /// <param name="capitalStrategy"></param>
    /// <param name="commitment"></param>
    /// <param name="outstanding"></param>
    /// <param name="riskRating"></param>
    /// <param name="maturity"></param>
    /// <param name="expiry"></param>
    public Loan(CapitalStrategy capitalStrategy, double commitment,
        double outstanding, int riskRating,
        DateTime maturity, DateTime expiry)
    {
        _commitment = commitment;
        _outstanding = outstanding;
        _riskRating = riskRating;
        _maturity = maturity;
        _expiry = expiry;
        _capitalStrategy = capitalStrategy;

        if (capitalStrategy == null)
        {
            if (expiry == null)
            {
                _capitalStrategy = new CapitalStrategyTermLoan();
            }
            else if (maturity == null)
            {
                _capitalStrategy = new CapitalStrategyRevolver();
            }
            else
            {
                _capitalStrategy = new CapitalStrategyRCTL();
            }
        }
    }
}

/// <summary>
///     Stub Classes to represent CapitalStrategy
/// </summary>
public abstract class CapitalStrategy { }

public class CapitalStrategyRCTL : CapitalStrategy { }

public class CapitalStrategyRevolver : CapitalStrategy { }

public class CapitalStrategyTermLoan : CapitalStrategy { }
