namespace MehotsProblems_SoftUni_;
class Program
{
    static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        int resulst = GetSmallestNumber(number1, number2, number3);
        Console.WriteLine(resulst);







    }

    private static int GetSmallestNumber(int number1, int number2, int number3)
    {
        int minNumber = int.MaxValue;

        if (number1 < minNumber) 
        {
            minNumber = number1;
        }
        if (number2 < minNumber)
        {
            minNumber = number2;
        }
        if(number3<minNumber)
        {
            minNumber = number3;
        }

        return minNumber;
    }
}

