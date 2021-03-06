using System;
using System.Collections.Generic;
using System.IO;

namespace Trees_and_Graphs
{
    class DFS_Traverse_Folders
    {
        public static void Main(string[] args)
        {
            TraverseDirBFS(@"C:\Windows\assembly");
        }
        private static void TraverseDirBFS(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);

            DirectoryInfo[] children = dir.GetDirectories();
            foreach (var DirectoryInfo child in children)
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