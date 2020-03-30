using System;
using System.IO;
using System.Runtime.InteropServices;
using C_fileIO101.Files.OSFileSystem;

namespace C_fileIO101.Files
{
    class WhichOS
    {
        public void RootFolder()
        {
            bool windows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            bool MAC = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
            bool linux = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

            if (windows)
            {
                Console.WriteLine("this is a windows system");
            }
            if (MAC)
            {
                Console.WriteLine("this is a MAC system");
            }
            if (linux)
            {
                Console.WriteLine("Enter a folder name you would like to create");
                string foldername = Console.ReadLine();
                new LinuxOS().linux(foldername);
            }

        }
    }

}