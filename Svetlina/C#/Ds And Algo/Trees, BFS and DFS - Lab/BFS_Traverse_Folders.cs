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
        public static void TraverseDirBFS(string directoryPath)
        {
            var visitedDirsQueue = new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));

            while (visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);

                foreach (DirectoryInfo child in currentDir.GetDirectories())
                {
                    visitedDirsQueue.Enqueue(child);
                }
            }
        }
    }
}