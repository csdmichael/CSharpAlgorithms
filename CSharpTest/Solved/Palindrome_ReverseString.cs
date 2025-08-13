using System;

public class Palindrome
{
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public static bool IsPalindrome(string word)
    {
        if (word.ToLower() == Reverse(word).ToLower())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /*
    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
    */
}