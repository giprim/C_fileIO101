using System;
using System.Collections;
using System.IO;

namespace C_fileIO101.Files
{
    public class ListFolderContent
    {
        public void listFolders(string aPath = "")
        {
            ArrayList directoryList = new ArrayList();

            string rootPath = new RootFolder().rootFolder();
            string[] folders = Directory.GetDirectories(rootPath + aPath);
            string[] files = Directory.GetFiles(rootPath);

            // Folders
            for (int i = 0; i < folders.Length; i++)
            {
                directoryList.Add(folders[i]);

                int folderPathName = folders[i].LastIndexOf('/');
                var folderName = folders[i].Substring(folderPathName + 1);
            }
            // files
            for (int j = 0; j < files.Length; j++)
            {
                directoryList.Add(files[j]);
            }

            // listAll
            if (directoryList.Count != -1)
            {
                for (int i = 0; i < directoryList.Count; i++)
                {
                    string theType = "folder";
                    if (directoryList[i].ToString().Contains('.'))
                    {
                        theType = "file";
                    }
                    int pathName = directoryList[i].ToString().LastIndexOf('/');
                    var name = directoryList[i].ToString().Substring(pathName + 1);
                    Console.WriteLine($"{i} <{theType}> == {name}");
                }
            }



        }
    }
}