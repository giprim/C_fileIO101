using System;
using System.IO;

namespace C_fileIO101.Files
{
    public class CreateFolder
    {
        public string createFolder(string path)
        {
            string pathReady = "";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    Console.WriteLine("Folder already exist");
                }

                pathReady = path;
            }
            catch (System.Exception e)
            {
                throw e;
            }

            return pathReady;
        }
    }
}