using System;
using System.IO;
using C_fileIO101.Files;

namespace C_fileIO101.Files.OSFileSystem
{
    public class LinuxOS
    {
        // file path == /home/$var/ConsoleFolder/$FolderName

        public void linux(string foldername)
        {
            CreateFolder createFolder = new CreateFolder();
            RootFolder rootFolder = new RootFolder();
            string rootPath = rootFolder.rootFolder();
            string path = rootPath + $"/{foldername}";
            string createdPath = createFolder.createFolder(path);
            Console.WriteLine(createdPath);
        }
    }
}