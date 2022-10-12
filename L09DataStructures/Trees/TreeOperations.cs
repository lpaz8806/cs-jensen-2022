namespace L09DataStructures.Trees;

public static class TreeOperations
{
    public static int CountNodes<T>(BinaryTree<T>? root)
    {
        if (root == null)
            return 0;
        
        return CountNodes(root.Left) + CountNodes(root.Right) + 1;
    }
    public static int CountNodes<T>(ITree<T>? root)
    {
        if (root == null)
            return 0;

        var count = 1;
        foreach (var child in root.Children)
        {
            count += CountNodes(child);
        }

        return count;
        
        return 
            1 +
            root.Children.Select(n => CountNodes(n)).Sum();
    }
}