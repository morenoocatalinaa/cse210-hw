using System;

class PromptUserNumber
{
    public static int GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        return userNumber;
    }
}
