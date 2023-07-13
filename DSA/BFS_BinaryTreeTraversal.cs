using DS;

namespace DSA;

public class BinaryTreeTraversal {
    public static void BFS_LevelOrder(TreeNode root) {
        if (root == null) {
            return;
        }

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while (q.Count > 0) {
            int size = q.Count;
            
            while (size > 0) {
                size--;
                TreeNode node = q.Dequeue();
                Console.Write($"{node?.Val}, ");
                
                if (node?.Left != null) {
                    q.Enqueue(node.Left);
                }
                
                if (node?.Right != null) {
                    q.Enqueue(node.Right);
                }
            }

            Console.WriteLine();
        }
    }

    public static void DFS_PreOrder(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        Console.Write($"{root.Val} ");
        DFS_PreOrder(root.Left);
        DFS_PreOrder(root.Right);
    }

    public static void DFS_InOrder(TreeNode? root) {
        if (root == null) {
            return;
        }

        DFS_InOrder(root.Left);
        Console.Write($"{root.Val} ");
        DFS_InOrder(root.Right);
    }

    public static void DFS_PostOrder(TreeNode? root) {
        if (root == null) {
            return;
        }

        DFS_PostOrder(root.Left);
        DFS_PostOrder(root.Right);
        Console.Write($"{root.Val} ");
    }
}
