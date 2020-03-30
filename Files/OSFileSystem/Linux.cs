using System;
using System.IO;
using C_fileIO101.Files;

namespace C_fileIO101.Files.OSFileSystem
{
    public class LinuxOS
    {
        // file path == /home/$var/$FolderName

        public void linux(string foldername)
        {
            try
            {
                string root = Directory.GetDirectoryRoot("/");
                string[] rootDir = Directory.GetDirectories(root);

                foreach (string dir in rootDir)
                {
                    if (dir.Equals("/home"))
                    {
                        string homePath = Directory.GetDirectories(dir)[0] + $"/{foldername}";
                        CreateFolder createFolder = new CreateFolder();
                        createFolder.createFolder(homePath);
                    }
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}