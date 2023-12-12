using System;
using System.Text;

namespace LeafRootBinarySum
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1,
            new TreeNode(0, new TreeNode(0), new TreeNode(1)),
            new TreeNode(1, new TreeNode(0), new TreeNode(1)));

            int result = LeafRootBinSum(root);
            Console.WriteLine(result);
        }
        public static int LeafRootBinSum(TreeNode root)
        {
            StringBuilder binaryPath = new StringBuilder();
            return DFS(root, binaryPath);
        }

        private static int DFS(TreeNode node, StringBuilder binaryPath)
        {
            if (node == null)
            {
                return 0;
            }

            binaryPath.Append(node.val);

            int value = 0;

           
            if (node.left == null && node.right == null)
            {
                value = Convert.ToInt32(binaryPath.ToString(), 2);
            }
            else
            {
                value += DFS(node.left, binaryPath);
                value += DFS(node.right, binaryPath);
            }

            binaryPath.Remove(binaryPath.Length - 1, 1);

            return value;
        }
    }
}