using System;
using System.IO;

namespace C_fileIO101.Files
{
    public class CreateFolder
    {
        public void createFolder(string path)
        {
            try
            {
                Console.WriteLine(path);
                // Directory.CreateDirectory(path);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}