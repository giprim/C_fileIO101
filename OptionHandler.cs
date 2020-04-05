using System;
using C_fileIO101.Files;
using C_fileIO101.Files.MenuItems;

class OptionHandler
{
    public void Handler(int option)
    {

        switch (option)
        {
            case (int)Options.READ:
                Console.WriteLine($"{Options.READ} a file");
                break;

            case (int)Options.WRITE:
                Console.WriteLine($"{Options.WRITE} to a file");
                break;

            case (int)Options.DELETE:
                Console.WriteLine($"{Options.DELETE} a file");
                break;

            case (int)Options.CREATEFOLDER:
                Console.WriteLine($"Creating a folder");
                new WhichOS().RootFolder();
                break;

            case (int)Options.CREATEFILE:

                new CreateFile().createFile();
                break;

            case (int)Options.LIST:
                Console.WriteLine("Listing Files");
                new ListFolderContent().displayFolderList();
                break;

            case (int)Options.EXIT:
                Environment.Exit(1);
                break;

            default:
                new DisplayOptions().displayOptions();
                break;
        }

    }
}