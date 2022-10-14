namespace L09DataStructures.Trees;

public static class TreeTraversals
{
    public static IEnumerable<T> BFS<T>(ITree<T> root)
    {
        var queue = new Queue<ITree<T>>();
        queue.Enqueue(root);
        
        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            yield return currentNode.Label;
            
            foreach (var child in currentNode.Children)
                queue.Enqueue(child);
        }
    }
    
    public static IEnumerable<T> PreOrder<T>(BinaryTree<T> root)
    {
        yield return root.Label;
        if(root.Left != null)
            foreach (var item in PreOrder(root.Left))
                yield return item;
        
        if(root.Right != null)
            foreach (var item in PreOrder(root.Right))
                yield return item;
    }
    public static IEnumerable<T> InOrder<T>(BinaryTree<T> root)
    {
        if(root.Left != null)
            foreach (var item in PreOrder(root.Left))
                yield return item;
        
        yield return root.Label;
        
        if(root.Right != null)
            foreach (var item in PreOrder(root.Right))
                yield return item;
    }
    public static IEnumerable<T> PostOrder<T>(BinaryTree<T> root)
    {
        if(root.Left != null)
            foreach (var item in PreOrder(root.Left))
                yield return item;
        
        if(root.Right != null)
            foreach (var item in PreOrder(root.Right))
                yield return item;
        
        yield return root.Label;
    }
}
