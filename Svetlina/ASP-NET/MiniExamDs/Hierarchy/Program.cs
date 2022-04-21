using System;
using System.Collections.Generic;
using SimpleTreeNode;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string employee = Console.ReadLine();
            TreeNode<string> tree = new TreeNode<string>("Boss",
                 new TreeNode<string>("Sarah",
                     new TreeNode<string>("Lora"),
                     new TreeNode<string>("Viktor")),
                 new TreeNode<string>("Evan",
                  new TreeNode<string>("Cole",
                     new TreeNode<string>("Mary"),
                     new TreeNode<string>("Clare")),
                  new TreeNode<string>("Nicole",
                     new TreeNode<string>("Alex",
                     new TreeNode<string>("Peter")),
                   new TreeNode<string>("Anya"))),
                 new TreeNode<string>("Mike"));
            BFS(tree,employee);
        }

        public static void BFS(TreeNode<string> Node, string name)
        {
            Queue<TreeNode<string>> employees = new Queue<TreeNode<string>>();
            employees.Enqueue(Node);

            while (employees.TryDequeue(out var targetNode))
            {
                Console.WriteLine(targetNode.Value);
                if (targetNode.Value.Equals(name))
                {
                    break;
                }
                foreach (var childNode in targetNode.ChildNodes)
                {   
                    employees.Enqueue(childNode);
                }
            }
        }
    }
}
