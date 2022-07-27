# Replace Constructors with Creation Methods

Constructors on a class make it hard to decide which constructor to call during development.

_Replace the constructors with intention-revealing **Creation Methods** that return object instances_

<img src="https://www.industriallogic.com/xp/refactoring/images/multipleconstructorwithcreator.jpg">

## Motivation

- By having multiple constructors, **programmers will have to choose which constructor to call** by studying the
  expected parameters and/or poking around at the constructor code;
- The more constructors you have, the easier it is for **programmers to choose the wrong one**;
- Having to choose which constructor to call **slows down development**;
- The code that does call one of the many constructors **often fails to sufficiently communicate the nature of the
  object being constructed**.
- Constructors simply **don’t communicate intention efficiently or effectively**;
- It’s common, particularly on mature systems, to find numerous constructors that are no longer being used yet continue
  to live on in the code - **also called dead constructors**.
- Dead constructors only **bloat a class** and make it more complicated than it needs to be.

### **A Creation Method can help make these problems go away.**

- A Creation Method is simply a static or nonstatic method on a class that instantiates new instances of the class.
- There are no name constraints on Creation Methods, so you can name them to **clearly express what you are creating**.
- It’s usually **easier to find dead Creation Method code than it is to find dead constructor code** (because the search
  expressions on
  specifically named methods are easier to formulate than the search expressions on one of a group of constructors).

## Benefits

- **Communicates** what kinds of instances are available **better than constructors**.
- Bypasses **constructor limitations**, such as the **inability** to have two constructors with the **same number** and
  type of **arguments**.
- Makes it **easier** to find **unused creation code**.

## Liabilities

- **Makes creation nonstandard**: some classes are instantiated using new, while others use Creation Methods.

## Mechanics

_Before beginning this refactoring, identify the **_catch-all_ constructor** - a full-featured constructor to which
other
constructors delegate their work._

1 - Find a client that calls a class’s constructor in order to create a kind of instance. Apply Extract Method on the
constructor call to produce a
public, static method. This new method is a creation method.

**_Compile and test_**

2 - **Find all callers of the chosen constructor** that instantiate the same kind of instance as the creation method
and **update them to call the creation method**.

**_Compile and test_**

3 - If the chosen constructor is **chained to another constructor**, make the creation method **call the chained
constructor** instead of
the chosen constructor.

**_Compile and test_**

4 - Repeat steps 1–3 for every constructor on the class that you’d like to turn into a Creation Method.

5 - **If a constructor** on the class **has no callers outside the class, make it non-public**.

**_Compile_**

## Example

_The example is inspired from the banking domain and a certain loan risk calculator. **The Loan class had numerous
constructors**._

Given that the calculator supported **seven kinds of loans, one might wonder why
Loan wasn’t an abstract superclass with a subclass for each kind of loan**. After all,
that would have cut down on the number of constructors needed for Loan and its
subclasses. There were two reasons why this was not a good idea.

1 - What **distinguishes the different kinds of loans** is not so much their fields
but how **numbers, like capital, income, and duration, are calculated**. To
support three different ways to calculate capital for a term loan, we
wouldn’t want to create **three different subclasses of Loan**. It’s **easier** to
support **one Loan class** and have **three different _Strategy_ classes** for a term
loan.

2 - The application that used Loan instances needed to **transform loans from one
kind of loan to another**. This transformation was **easier** to do when it
involved **changing a few fields on a single Loan instance, rather than
completely changing one instance of a Loan subclass into another**.

**The Loan class has five constructors, the last of which is its _catch-all_ constructor. Without specialized knowledge,
it is
difficult to know which constructors create term loans, which ones create revolvers, and which ones create RCTLs**.

What else is embedded as implicit knowledge in the Loan constructors? Plenty. If
you call the first constructor, which takes three parameters, you’ll get back a term
loan. But if you want a revolver, you’ll need to call one of the constructors that take
two dates and then supply null for the maturity date. I wonder if all users of this
code will know this? Or will they just have to learn by encountering some ugly defects?

_Let's see what happens when we apply the Replace Constructors with Creation Methods refactoring._

## Refactoring

After refactoring we end up with the following creation methods:

```csharp
public class LoanRefactored {
    // Private Constructor
    private LoanRefactored(double commitment, int riskRating, DateTime maturity, double outstanding = default, CapitalStrategy? capitalStrategy = default, DateTime? expiry = default)
    // Creational Methods
    public static LoanRefactored CreateTermLoan(double commitment, int riskRating, DateTime maturity);
    public static LoanRefactored CreateTermLoan(CapitalStrategy? riskAdjustedCapitalStrategy, double commitment, double outstanding, int riskRating, DateTime maturity)
    public static LoanRefactored CreateRevolver(double commitment, double outstanding, int riskRating, DateTime expiry);
    public static LoanRefactored CreateRevolver(CapitalStrategy capitalStrategy, double commitment, double outstanding, int riskRating, DateTime? expiry)
}
```

## Remarks

- Passing in null values to a constructor is bad practice. It reduces the code’s readability. It usually happens because
  programmers
  can’t find the exact constructor they need, so instead of creating yet another
  constructor they call a more general-purpose one.

- Why did I choose to overload **createTermLoan(…)** instead of producing a creation method with a unique name, like **
  createTermLoanWithStrategy(…)**?
  Because I felt that the presence of the CapitalStrategy parameter sufficiently
  communicated the difference between the two overloaded versions of
  **createTermLoan(…)**.
