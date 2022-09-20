using System;
using System.Collections.Generic;
using System.IO;

namespace Trees_and_Graphs
{
    class DFS_Traverse_Folders_and_Files
    {
        public static void Main(string[] args)
        {
            TraverseDirBFS(@"C:\Windows\assembly");
        }
        private static void TraverseDirDFS(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);

            FileInfo[] files = dir.GetFiles();

            foreach (var file in files)
            {
                Console.WriteLine(spaces + " " + file.FullName);
            }

            DirectoryInfo[] children = dir.GetDirectories();

            foreach (DirectoryInfo child in children)
            {
                TraverseDirDFS(child, spaces + " ");
            }
        }

        public static void TraverseDirBFS(string directoryPath)
        {
            TraverseDirDFS(new DirectoryInfo(directoryPath), string.Empty);
        }
    }
}