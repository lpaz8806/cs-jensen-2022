namespace L10DesignPrinciples.DesignPatterns;

public class StrategyPattern
{
    public static void Run()
    {
        Run(new JuniorDevSalary());
    }
    static void Run(ISalaryStrategy strg)
    {
        Console.WriteLine(strg.ComputeSalary());
    }
}

public interface ISalaryStrategy
{
    double ComputeSalary();
}

public class CLevelSalary : ISalaryStrategy
{
    public double ComputeSalary()
    {
        return double.PositiveInfinity;
    }
}

public class JuniorDevSalary : ISalaryStrategy
{
    public double ComputeSalary()
    {
        return 20000.0;
    }
}