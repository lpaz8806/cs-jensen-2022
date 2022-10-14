namespace L09DataStructures.Trees;

public static class TreeOperations
{
    public static int CountNodes<T>(BinaryTree<T>? root)
    {
        if (root == null)
            return 0;
        
        return CountNodes(root.Left) + CountNodes(root.Right) + 1;
    }
    public static int CountNodes<T>(ITree<T> root)
    {
        return 1 + root.Children.Sum(CountNodes);
    }

    public static int SumLabels(ITree<int> root)
    {
        return root.Label + root.Children.Sum(SumLabels);
    }
    public static int Max(ITree<int> root)
    {
        return Math.Max(
            root.Label,
            root.Children.Max(Max) // The first Max is Linq, the second is the recursive call
        );
    }
}