using System;
using C_fileIO101.Files;

class OptionHandler
{
    public void Handler(int option)
    {

        switch (option)
        {
            case (int)Options.READ:
                Console.WriteLine($"you want to {Options.READ} a file");
                break;

            case (int)Options.WRITE:
                Console.WriteLine($"you want to {Options.WRITE} to a file");
                break;
            case (int)Options.DELETE:
                Console.WriteLine($"you want to {Options.DELETE} a file");
                break;
            case (int)Options.CREATEFOLDER:
                Console.WriteLine($"you want to {Options.CREATEFOLDER} a file");
                new WhichOS().RootFolder();
                break;

            default:
                new DisplayOptions().displayOptions();
                break;
        }

    }
}