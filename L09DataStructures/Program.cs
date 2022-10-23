
using L09DataStructures.Queue;
using L09DataStructures.Trees;

void PlayingWithTrees()
{
    var tree = new BinaryTree<int>(
        1,
        new BinaryTree<int>(69,
            new BinaryTree<int>(3)
        ),
        new BinaryTree<int>(666,
            new BinaryTree<int>(1),
            new BinaryTree<int>(7)
        )
    );

    Console.WriteLine(
        string.Join(", ",
            TreeTraversals.BFS(tree)
        )
    );
    
    var tree2 = new Tree<int>(
        1,
        new Tree<int>(2,
            new Tree<int>(7),
            new Tree<int>(5)
        ),
        new Tree<int>(3),
        new Tree<int>(4)
    );
    Console.WriteLine(TreeOperations.CountNodes(tree2));
}


var queue = new LinkedQueue<int>();
queue.Enqueue(5);
queue.Enqueue(6);
Console.WriteLine(string.Join(", ", queue));
queue.Dequeue();
Console.WriteLine(string.Join(", ", queue));
queue.Dequeue();
Console.WriteLine(string.Join(", ", queue));
queue.Dequeue();
