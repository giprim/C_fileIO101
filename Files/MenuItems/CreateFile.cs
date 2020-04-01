using System;
using System.IO;

namespace C_fileIO101.Files.MenuItems
{
    public class CreateFile
    {
        RootFolder rootFolder = new RootFolder();

        public void createFile()
        {
            string rootPath = rootFolder.rootFolder();

            try
            {
                Console.WriteLine($"Enter a file name with an extension eg. filename.txt");
                string filename = Console.ReadLine();

                if (filename.Contains('.'))
                {
                    if (!File.Exists(rootPath + "/" + filename))
                        File.Create($"{rootPath}/{filename}");
                    else Console.WriteLine("File already exists");
                }
                else
                {
                    Console.WriteLine("Please make sure your new file has an extension");
                    new CreateFile().createFile();
                }

            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}