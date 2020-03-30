using System;
class DisplayOptions
{
    public void displayOptions()
    {
        try
        {
            Console.WriteLine("Please choose the action you want to perform");
            Console.WriteLine();
            Console.WriteLine($"Enter {(int)Options.CREATEFOLDER} to Create a folder");
            Console.WriteLine($"Enter {(int)Options.CREATEFILE} to Create a file");
            Console.WriteLine($"Enter {(int)Options.READ} to Read file");
            Console.WriteLine($"Enter {(int)Options.WRITE} to Write to a file");
            Console.WriteLine($"Enter {(int)Options.DELETE} to Delete file");
            Console.WriteLine("====================");
            Console.WriteLine($"Enter {(int)Options.LIST} to List file");
            int inputOption = Convert.ToInt32(Console.ReadLine());
            OptionHandler optionH = new OptionHandler();
            optionH.Handler(inputOption);
        }
        catch (System.Exception)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Please Strings are not allowed!!! Only Numbers");
            Console.WriteLine("================================================");

            new DisplayOptions().displayOptions();
        }
    }
}