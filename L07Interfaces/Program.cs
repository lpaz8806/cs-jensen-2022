namespace L07Interfaces;

class Program
{
    static void Main(string[] args)
    {
    }
    
    static void ArraySort(int[] items)
    {
        for (var i = 0; i < items.Length - 1; i++)
        for (var j = i + 1; j < items.Length; j++)
            if (items[i] < items[j])
            {
                var temp = items[j];
                items[j] = items[i];
                items[i] = temp;
            }
    }
}