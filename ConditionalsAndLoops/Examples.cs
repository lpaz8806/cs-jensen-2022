namespace ConditionalsAndLoops;

partial class Program
{
    #region Using Enum types

    /// <summary>
    /// Adds the specified amount of months to a given month
    /// </summary>
    /// <example>
    /// AddSpan(Month.January, 5) returns Month.June
    /// AddSpan(Month.December, 1) returns Month.January
    /// </example>
    /// <param name="month"></param>
    /// <param name="monthsToAdd"></param>
    /// <returns></returns>
    static Month AddMonths(Month month, int monthsToAdd)
    {
        // Take the integer code of the month.
        var monthCode = (int)month;
        // Add the amount of month and compute the reminder of the division by 12 (12 months of the year)
        monthCode = (monthCode + monthsToAdd) % 12;
        // return the resulting code as as Month
        return (Month)monthCode;
    }

    /// <summary>
    /// Computes the amount of days that the specified month has.
    /// This method does not take into consideration the leap years (years in which February have 29 days)
    /// </summary>
    /// <param name="month"></param>
    /// <returns>An integer between 1 and 31</returns>
    static int DaysInMonth(Month month)
    {
        switch (month)
        {
            case Month.January:
            case Month.March:
            case Month.May:
            case Month.July:
            case Month.August:
            case Month.October:
            case Month.December:
                return 31;

            case Month.February:
                // Can you modify this method to consider leap years?
                return 28;

            default:
                return 30;
        }
    }
    

    #endregion

    #region Maximum of two numbers

    static int Max(int x, int y)
    {
        var max = x >= y ? x : y;
        return max;
        
        // Ternary operator
        // <bool condition> ? <true_expr> : <false_expr>;
        /*
        if (x > y)
            return x;
        else
            return y;
        */
    }
    static int Max(int x, int y, int z)
    {
        // This is the "Pro" implementation
        // The reason to call it this way is because it uses previous knowledge
        // We use here the implementation of Max taking two numbers and reuse it here
        // Not reinventing the wheel is in great part the difference between a pro programmer
        // and a junior.
        
        var maxOfXandY = Max(x, y);
        return Max(maxOfXandY, z);
    }
    
    static int MaxWithAGoodIdea(int x, int y, int z)
    {
        // The idea is to assume the first element (x) as the max
        // and update it when you find a greater one.
        // This simple idea can be used in a loop to compute the max of any amount of
        // numbers
        // :) Wait for next Wednesday. We will use this idea :)
        var max = x;

        if (y >= max) max = y;
        if (z >= max) max = z;
        
        return max;
    }
    
    static int MaxWithLessBranching(int x, int y, int z)
    {
        // By using combination of boolean expression you can reduce the amount of if-statements
        // This improves readability
        
        if (x >= y && x >= z)
            return x;

        if (y >= x && y >= z)
            return y;
        
        return z;
    }
    
    static int MaxNaive(int x, int y, int z)
    {
        if (x >= y)
        {
            if (x >= z)
                return x;
            else
                return z;

        }
        else
        {
            if (y >= z)
                return y;
            else
                return z;
        }
    }

    #endregion

    #region Average
    /// <summary>
    /// Computes the average of the specified numbers
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    static double Average(double x, double y)
    {
        return (x + y) / 2.0;
    }
    
    #endregion
}