namespace ConditionalsAndLoops;

partial class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Type a number: ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;
            var n = int.Parse(input);
            Console.WriteLine("Is {0} prime? {1}", n, IsPrime(n));
        }
    }
}

