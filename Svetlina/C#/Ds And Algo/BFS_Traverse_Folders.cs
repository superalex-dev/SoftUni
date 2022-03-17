using System;
using System.Collections.Generic;
using System.IO;

namespace Trees_and_Graphs
{
    class BFS_Traverse_Folders
    {
        public static void Main(string[] args)
        {
            TraverseDirBFS(@"C:\Windows\assembly");
        }
        private static void TraverseDirBFS(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);

            DirectoryInfo[] children = dir.GetDirectories();
            foreach (DirectoryInfo child in children)
            {
                TraverseDirBFS(child, spaces + " ");
            }
        }

        public static void TraverseDirBFS(string directoryPath)
        {
            TraverseDirBFS(new DirectoryInfo(directoryPath), string.Empty);
        }
    }
}