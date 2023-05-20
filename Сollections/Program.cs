using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        PM pm = new PM();
        Console.WriteLine(pm.PM1(new[] {1, 2, 3}));
        Console.WriteLine(pm.PM1(new[] {3, 2, 1}));

        ReadFile readFile = new ReadFile();
        readFile.ReadFile1();
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