using System;
using System.IO;

namespace C_fileIO101.Files
{
    public class ListFolderContent
    {
        public void listFolders()
        {
            string rootPath = new RootFolder().rootFolder();
            string[] folders = Directory.GetDirectories(rootPath);

            for (int i = 0; i < folders.Length; i++)
            {
                Console.WriteLine($"{i} = {folders[i]}");
            }
            // Console.WriteLine(rootPath);

        }
    }
}