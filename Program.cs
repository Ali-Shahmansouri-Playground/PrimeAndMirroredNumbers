using System.Numerics;

int requestCode = GetRequestCode();
int rangeStart = ReadLineParsed("Enter the range start: ");
int rangeEnd = ReadLineParsed("Enter the end of the range: ");

if (rangeStart > rangeEnd)
{
    (rangeEnd, rangeStart) = (rangeStart, rangeEnd);
}

// Find Prime Numbers
if (requestCode == 1)
{
    Console.WriteLine($"\nPrime Numbers between {rangeStart} and {rangeEnd}: ");

    for (int i = rangeStart; i <= rangeEnd; i++)
    {
        if (IsPrime(i) && i >= 2) Console.WriteLine(i);
    }

}
//Find MirroredNumbers
else
{
    Console.WriteLine($"\nMirrored Numbers between {rangeStart} and {rangeEnd}: ");

    for (int i = rangeStart; i <= rangeEnd; i++)
    {
        // 10 <= i ? Single Digit numbers are not considered as mirrored
        if (i.ToString().Equals(new string(i.ToString().Reverse().ToArray())) && 10 <= i)
            Console.WriteLine(i);
    }
}

int GetRequestCode()
{
    try
    {
        int enteredNumber = ReadLineParsed("Enter <1> to get prime numbers or enter <2> to get mirrored numbers: ");
        if (enteredNumber > 2 || enteredNumber < 1)
            throw new ArgumentOutOfRangeException("Unmatched Requset Code");

        return enteredNumber;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine("Please enter a valid number.");
        return GetRequestCode();
    }
}

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

bool IsPrime(int number)
{
    for (int i = 2; i * i <= number; i++)
    {
        if (number != i && number % i == 0) return false;
    }
    return true;
}