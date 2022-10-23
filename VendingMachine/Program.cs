
class Program
{
    private static List<(string name, int price)> products;
    private static int attBetala;
    
    static void Main(string[] args)
    {
        products = InitProducts();
        Run();
    }

    static void Run()
    {
        while (true)
        {
            ShowMenu();
            var input = ReadInput();
            if (string.IsNullOrEmpty(input))
                break;
            
            var choice = ComputeChoice(input);
            AddToBill(choice);
        }

        if (attBetala > 0)
        {
            Console.WriteLine($"Att betala: {attBetala} kr");
        }
    }

    static string ReadInput()
    {
        Console.Write("Your choice: ");
        return Console.ReadLine() ?? string.Empty;
    }
    static (string name, int price) ComputeChoice(string input)
    {
        int choice = int.Parse(input);
        choice -= 1;
        return products[choice];
    }
    
    static void ShowMenu()
    {
        Console.Clear();
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(
                "{0}. {1} ({2} kr)",
                i+1,
                products[i].name,
                products[i].price
            );
        }
    }

    static void AddToBill((string name, int price) product)
    {
        attBetala += product.price;
    }
    static List<(string name, int price)> InitProducts()
    {
        return new List<(string name, int price)>()
        {
            ("Coca cola", 10),
            ("Pringles", 15),
            ("Zingo", 15),
            ("Pripps blå 7.0%", 85),
        };
    }
}