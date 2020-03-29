using System;
class DisplayOptions
{
    public void displayOptions()
    {
        try
        {
            Console.WriteLine("Please choose the action you want to perform");
            Console.WriteLine();
            Console.WriteLine("Enter 1 to Read file");
            Console.WriteLine("Enter 2 to Write to a file");
            Console.WriteLine("Enter 3 to Delete file");
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