using System;
using C_fileIO101.Files;

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
                Console.WriteLine($"Create a folder");
                new WhichOS().RootFolder();
                break;

            default:
                new DisplayOptions().displayOptions();
                break;
        }

    }
}