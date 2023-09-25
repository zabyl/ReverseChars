using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen tersten yazdırmak istediğiniz kelimeyi veya kelimeleri aralarında boşluk bırakarak giriniz: ");
        string line = Console.ReadLine();
        Console.WriteLine("\nOriginal String: " + line);
        string revString = ReverseString(line);
        ReverseChars(revString);
    }
    static string ReverseString(string sentence)
    {
        string result = "";
        string reversed = "";
        List <string> wordsList = new List <string>();
        string[] words = sentence.Split(new [] {" "}, StringSplitOptions.None);
        for (int i = words.Length - 1; i >= 0; i--) {result += words[i] + " ";}
        wordsList.Add(result);
        foreach(String s in wordsList) 
        {   
        reversed += s;
        }
        return reversed;
    }
    static void ReverseChars(string str)
    {
        char[] stringArray = str.ToCharArray();
        Array.Reverse(stringArray);
        string reversedStr = new string(stringArray);
        Console.Write($"Reversed String is : {reversedStr} ");
    }
}