using System;
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

            default:
                new DisplayOptions().displayOptions();
                break;
        }

    }
}