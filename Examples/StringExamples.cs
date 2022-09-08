namespace Examples;

public class StringExamples
{
    public static string AlignLeft(string str, int width)
    {
        if (str.Length >= width)
            return str.Substring(0, width);
        
        return str.PadRight(width, ' ');
    }
    
    public static string AlignRight(string str, int width)
    {
        if (str.Length >= width)
            return str.Substring(0, width);
        
        return str.PadLeft(width, ' ');
    }
    
    public static string AlignCenter(string str, int width)
    {
        if (str.Length >= width)
            return str.Substring(0, width);
        
        var leftWidth = 0;
        var rightWidth = 0;
        
        return str
            .PadLeft(leftWidth, ' ')
            .PadRight(rightWidth, ' ');
    }
}