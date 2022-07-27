// Licensed to the.NET Foundation under one or more agreements.
// The.NET Foundation licenses this file to you under the MIT license.
namespace ReplaceConstructorsWithCreationMethods;

/// <summary>
/// Loan class Refactored with Creation Methods
/// </summary>
public class LoanRefactored
{
    private readonly CapitalStrategy? _capitalStrategy;
    private readonly double _commitment;
    private readonly DateTime? _expiry;
    private readonly DateTime? _maturity;
    private readonly double _outstanding;
    private readonly int _riskRating;

    /// <summary>
    ///     Catch-all constructor
    /// </summary>
    /// <param name="capitalStrategy"></param>
    /// <param name="commitment"></param>
    /// <param name="outstanding"></param>
    /// <param name="riskRating"></param>
    /// <param name="maturity"></param>
    /// <param name="expiry"></param>
    private LoanRefactored(CapitalStrategy? capitalStrategy, double commitment, double outstanding, int riskRating,
        DateTime maturity = default, DateTime? expiry = default)
    {
        _commitment = commitment;
        _outstanding = outstanding;
        _riskRating = riskRating;
        _maturity = maturity;
        _expiry = expiry;

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


    public static LoanRefactored CreateTermLoan(double commitment, int riskRating, DateTime maturity)
    {
        return new(default, commitment, default, riskRating, maturity);
    }

    public static LoanRefactored CreateTermLoan(
        CapitalStrategy? riskAdjustedCapitalStrategy,
        double commitment,
        double outstanding,
        int riskRating,
        DateTime maturity)
    {
        return new LoanRefactored(riskAdjustedCapitalStrategy, commitment, outstanding, riskRating, maturity);
    }

    public static LoanRefactored CreateRevolver(double commitment, double outstanding, int riskRating, DateTime expiry)
    {
        return new LoanRefactored(default, commitment, outstanding, riskRating, expiry);
    }

    public static LoanRefactored CreateRevolver(CapitalStrategy capitalStrategy, double commitment, double outstanding,
        int riskRating, DateTime expiry)
    {
        return new LoanRefactored(capitalStrategy, commitment, outstanding, riskRating, expiry);
    }
}
