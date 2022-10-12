namespace L09DataStructures.Trees;

public static class TreeTraversals
{
    public static IEnumerable<T> BFS<T>(BinaryTree<T> root)
    {
        var queue = new Queue<BinaryTree<T>>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            yield return item.Label;
            
            if(item.Left != null)
                queue.Enqueue(item.Left);
            
            if(item.Right != null)
                queue.Enqueue(item.Right);
        }
    }
    
    public static IEnumerable<T> PreOrder<T>(BinaryTree<T> root)
    {
        yield break;
    }
    public static IEnumerable<T> InOrder<T>(BinaryTree<T> root)
    {
        yield break;
    }
    public static IEnumerable<T> PostOrder<T>(BinaryTree<T> root)
    {
        yield break;
    }


}