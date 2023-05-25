using System.Diagnostics;
using System.Net;

class Program
    {
        static void Main(string[] args)
        {
        StopWatch stopWatch = new StopWatch();

        string path = File.ReadAllText("D:/VS/Новая папка/Text.txt");

        List<string> list = new List<string>();
        list.Add(path);
        stopWatch.Estimate(list.Count);

        LinkedList<string> strings = new LinkedList<string>();
        strings.AddFirst(path);
        stopWatch.Estimate(list.Count);
    }
    }
class StopWatch
{
    static void CreateMatrix(int n)
    {
        var matrix = new int[n][];

        for (int i = 0; i < n; i++)
        {
            matrix[i] = new int[n];
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] = i + j;
            }
        }
    }

    public void Estimate(int n)
    {
        var timer = new Stopwatch();
        timer.Start();

        for (int i = 0; i < n; i++)
        {
            timer.Restart();

            CreateMatrix(10000);

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }
    }
}