namespace Examples;

public class RichestCountry
{
    public static void Run()
    {
        var rightAnswer = "Kina";
        Console.WriteLine("What is the richest country?");

        while (true)
        {
            var answer = Console.ReadLine();
            if (answer.ToLower() == rightAnswer.ToLower())
                break;
            Console.WriteLine("Wrong answer!");
        }
        Console.WriteLine("Right!");
    }

    private static void FirstSolution()
    {
        Console.WriteLine("What is the richest country");
        var answer = Console.ReadLine();
        var rightAnswer = "kina";
        
        while (answer.ToLower() != rightAnswer.ToLower())
        {
            Console.WriteLine("Wrong!");
            answer = Console.ReadLine();
        }

        Console.WriteLine("Right!");
    }
}