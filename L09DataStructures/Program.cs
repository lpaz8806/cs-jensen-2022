
using L09DataStructures.Trees;

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