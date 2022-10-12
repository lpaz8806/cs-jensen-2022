namespace L09DataStructures.Trees;

public class BinaryTree<T>
{
    public T Label { get; set; }
    public BinaryTree<T>? Left { get; set; }
    public BinaryTree<T>? Right { get; set; }

    public BinaryTree(T label, BinaryTree<T>? left = null, BinaryTree<T>? right = null)
    {
        Label = label;
        Left = left;
        Right = right;
    }

    public override string ToString()
    {
        return Label?.ToString() ?? string.Empty;
    }
}