using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    private static SortedDictionary<string, Contact> PhoneBook = new SortedDictionary<String, Contact>()
    {
        ["Игорь"] = new Contact(79990000000, "igor@example.com"),
        ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
    };

    public static void WriteAllContacts()
    {
        foreach (var contact in PhoneBook)
            Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
        Console.WriteLine();
    }
    public class Contact 
    {
        public Contact(long phoneNumber, String email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Текущий список контактов: ");
        WriteAllContacts();

        PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

        Console.WriteLine("Обновленный список контактов: ");
        WriteAllContacts();

        if (PhoneBook.TryGetValue("Диана", out Contact contact))
            contact.PhoneNumber = 79990000001;

        Console.WriteLine("Список после изменения: ");
        WriteAllContacts();

        var stopWatch = Stopwatch.StartNew();
        var result = 50063 / 834;
        Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

        var months = new List<string>()
{
   "Jan", "Feb", "Mar", "Apr", "May"
};
        var missing = new ArrayList()
{
   1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
};

        var copy = new string[7];

        missing.GetRange(4, 7).CopyTo(copy);
        months.AddRange(copy);

        foreach (var month in months)
        {
            Console.WriteLine(month);
        }

        string[] names =  {
           "Игорь",   // повторяющееся значение
               "Андрей",
               "Васиий",
               "София",
               "Елена",
               "Анна",
               "Игорь"  //  повторяющееся значение
           };


        Console.WriteLine("Длина массива " + names.Length);
        Console.WriteLine();
        Console.WriteLine("Данные в массиве");
        foreach (var n in names)
            Console.WriteLine(n);
        Console.WriteLine();


        HashSet<string> hSet = new HashSet<string>(names);

        Console.WriteLine("Длина хэш-сета " + hSet.Count);
        Console.WriteLine();

        Console.WriteLine("Элементы в хэшсете:");
        hSet.UnionWith(new[] { "Дмитрий", "Сергей", "Игорь" });

        Console.WriteLine("Элементы после объединения с новой коллекцией:");

        foreach (var n in hSet)
            Console.WriteLine(n);
        // Создадим два множества
        SortedSet<char> lettersOne = new SortedSet<char>();
        SortedSet<char> lettersTwo = new SortedSet<char>();

        //  Добавим элементы в первую
        lettersOne.Add('A');
        lettersOne.Add('B');
        lettersOne.Add('C');
        lettersOne.Add('Z');

        // выведем
        PrintCollection(lettersOne, "Первая коллекция: ");

        // Добавим элементы во вторую
        lettersTwo.Add('X');
        lettersTwo.Add('Y');
        lettersTwo.Add('Z');

        // выведем
        PrintCollection(lettersTwo, "Вторая коллекция");

        //  Выполним вычитание множеств
        lettersOne.ExceptWith(lettersTwo);

        // Выведем результат
        PrintCollection(lettersOne, "Результат вычитания");


        while (true) 
        { 
        var str = Console.ReadLine();
        var characters = str.ToCharArray();
        var symbols = new HashSet<char>(' ');
        foreach (var symbol in characters)
            symbols.Add(symbol);
        Console.WriteLine(symbols.Count);

        var signs = new[] { ',', ' ', '.' };
        var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        bool containsNumbers = symbols.Overlaps(numbers);
        Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

        symbols.ExceptWith(signs);
        Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");
         }

    }

    static void PrintCollection(SortedSet<char> ss, string s)
    {
        Console.WriteLine(s);
        foreach (char ch in ss)
            Console.Write(ch + " ");
        Console.WriteLine("\n");
    }
}