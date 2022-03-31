using System;
class Program
{
    static void Main()
    {
        string[] passWords = { };
        foreach (string passWord in passWords)
        {
            bool b = ValidatePassword(passWord);
            Console.WriteLine("'{0}' is{1} a valid password", passWord, b ? "" : "n't");
        }
        Console.ReadKey();
    }
    static bool ValidatePassword(string passWord)
    {
        int validConditions = 0;
        foreach (char c in passWord)
        {
            if (c >= 'a' && c <= 'z')
            {
                validConditions++;
                break;
            }
        }
        foreach (char c in passWord)
        {
            if (c >= 'A' && c <= 'Z')
            {
                validConditions++;
                break;
            }
        }
        if (validConditions == 0) return false;
        foreach (char c in passWord)
        {
            if (c >= '0' && c <= '9')
            {
                validConditions++;
                break;
            }
        }
        if (validConditions == 1) return false;
        if (validConditions == 2)
        {
            char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' };
            if (passWord.IndexOfAny(special) == -1) return false;
        }
        return true;
    }
}
