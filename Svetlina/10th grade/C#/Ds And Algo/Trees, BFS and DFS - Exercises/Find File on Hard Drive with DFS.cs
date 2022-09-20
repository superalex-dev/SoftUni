using System;
using System.IO;

public static class FindFile
{
    private static void TraverseDirDFS(DirectoryInfo dir, string fileName)
    {
        try
        {
            if (dir.Name == fileName)
            {
                Console.WriteLine($"{dir.Name} is found in {dir.FullName}.");
            }
            foreach (var directory in dir.GetDirectories())
            {
                TraverseDirDFS(directory, fileName);
            }
        }
        catch
        {
            Console.WriteLine($"No access to {dir}");
        }
    }

    public static void TraverseDirDFS(string directoryPath, string fileName)
    {
        TraverseDirDFS(new DirectoryInfo(directoryPath), fileName);
    }

    static void Main()
    {
         TraverseDirDFS(@"C:\", "Trees-BFS-DFS-Exercises.docx"); 
    }
}