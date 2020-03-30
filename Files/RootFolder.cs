using System.IO;

namespace C_fileIO101.Files
{
    public class RootFolder
    {
        public string rootFolder()
        {
            string path = "";

            try
            {
                string root = Directory.GetDirectoryRoot("/");
                string[] rootDir = Directory.GetDirectories(root);

                foreach (string dir in rootDir)
                {
                    if (dir.Equals("/home"))
                    {
                        string homePath = Directory.GetDirectories(dir)[0] + "/ConsoleFolder";

                        if (!Directory.Exists(homePath))
                        {
                            Directory.CreateDirectory(homePath);
                        }
                        path = homePath;
                    }
                }
            }
            catch (System.Exception)
            {
                throw;
            }

            return path;
        }
    }
}