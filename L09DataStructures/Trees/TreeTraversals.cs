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