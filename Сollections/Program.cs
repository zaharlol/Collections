using System.Collections;
using System.Globalization;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        PM pm = new PM();
        Console.WriteLine(pm.PM1(new[] {1, 2, 3}));
        Console.WriteLine(pm.PM1(new[] {3, 2, 1}));

        ReadFile readFile = new ReadFile();
        readFile.ReadFile1();

        Months months = new Months();
        months.Months1();

        ArrayEx arrayEx = new ArrayEx();
        arrayEx.ArrayEx1();
    }
}
class ReadFile
{
    public void ReadFile1() 
    {
        string path = File.ReadAllText(@"D:/VS/Новая папка/cdev_Text.txt");
        char[] simvol = { ' ', '\r', '\n' };
        var words = path.Split(simvol, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Length);
    }
}
public class PM
{
    public bool PM1(int[] array)
    {
        for ( int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i])
                return false;
        }
        return true;
    }
}
class ArrayEx
{
    public void ArrayEx1()
    {
        var example = new ArrayList()
           {
               1,
               "Самая ",
               "лучшая ",
               "коллекция",
               300,
           };

        int sum = 0;

        StringBuilder text = new StringBuilder();

        foreach (var item in example) 
        {
            if (item is int)
            {
                sum += (int)item;
            }
        }
        foreach (var item in example)
        {
            if (item is string)
            {
                text.Append(item);
            }
        }

        var result = new ArrayList {sum, text.ToString()} ;

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
class Months
{
    public void Months1()
    {
        var months = new[]
{
   "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        var numbers = new[]
        {
   1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
        };

        var combinedList = new ArrayList();

        foreach (var number in numbers)
        {
            combinedList.Add(months[number - 1]);
            combinedList.Add(number);
        }

        foreach (var value in combinedList)
            Console.WriteLine(value);
    }
}