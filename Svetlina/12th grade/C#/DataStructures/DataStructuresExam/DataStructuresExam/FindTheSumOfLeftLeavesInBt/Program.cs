using System;

namespace FindTheSumOfLeftLeavesInBt
{
    class Program
    {

        public static int FindTheSumOfBTLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int sum = 0;

            if (root.left != null)
            {
                if (root.left.left == null && root.left.right == null)
                {
                    sum += root.left.val;
                }
                else
                {
                    sum += FindTheSumOfBTLeftLeaves(root.left);
                }
            }

            sum += FindTheSumOfBTLeftLeaves(root.right);

            return sum; 
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20, new TreeNode(15), null);

            int sum = FindTheSumOfBTLeftLeaves(root);
            Console.WriteLine(sum);
        }
    }
}