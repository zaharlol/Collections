using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
     
        }
    }
}
class Ochered
{
    public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();
    static void Ochered1()
    {
    Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
            Console.WriteLine();

            StartQueueProcessing();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "peek")
                {
                    if (words.TryPeek(out var elem))
                        Console.WriteLine(elem);
                }
                else
{
    words.Enqueue(input);
}
            }
            static void StartQueueProcessing()
{
    new Thread(() =>
    {
        Thread.CurrentThread.IsBackground = true;

        while (true)
        {

            if (words.TryDequeue(out var element))
                Console.WriteLine("======>  " + element + " прошел очередь");
        }

    }).Start();
}
}
}
class Ctek
{
    public static Stack<string> words = new Stack<string>();
    static void Ctek1()
    {
        while (true)
        {
            var input = Console.ReadLine();

            words.Push(input); // Изменить здесь

            if (input == "pop")
            {
                words.Pop();
                words.Pop();
            }
            if (input == "peek")
            {
                words.Pop();
                Console.WriteLine();
                Console.WriteLine(words.Peek());
                continue;
            }

            Console.WriteLine();
            Console.WriteLine("В стеке:");

            foreach (var word in words)
            {
                Console.WriteLine(" " + word);
            }
        }
    }
}