using System.Collections.Generic;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText("D:\\VS\\Новая папка\\Text.txt");
        var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
        var words = text.Split(noPunctuationText, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Length);
    }
}