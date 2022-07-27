using ReplaceConstructorsWithCreationMethods;

var loadRefactored = LoanRefactored.CreateTermLoan(new CapitalStrategyRevolver(), double.MinValue, double.MinValue,
    int.MinValue, DateTime.Now.AddDays(30));

Console.WriteLine(loadRefactored.ToString());
