using System.Collections.Generic;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText("D:\\VS\\Новая папка\\Text.txt");

        List<string> list = new List<string>();
        list.Add(text);

        if (list.Contains("Annotation"))
        {
            foreach(var b in list) 
            Console.WriteLine(b);
        }
 
        var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
        var words = text.Split(noPunctuationText, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words)
        Console.WriteLine(word);
    }
}
// не понимаю как делать