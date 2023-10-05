using System.Numerics;

int ReadLineParsed(string message)
{
    Console.WriteLine(message);
    try
    {
        return int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message + "\n Please enter a valid number.");
        return ReadLineParsed(message);
    }
}