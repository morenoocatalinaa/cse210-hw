using System;

class PromptUserName
{
    public static string GetName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
}
