namespace _08.Factorial_Division;
class Program
{
    static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        double result = CalculateFactorialNumberOne(number1) / CalculateFactorialNumberTwo(number2);

        Console.WriteLine($"{result:f2}");


        
    }

    static long CalculateFactorialNumberOne(int number1)
    {
        long factorial = 1;
        for (int i = 1; i <= number1; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static long CalculateFactorialNumberTwo(int number1)
    {
        long factorial = 1;
        for (int i = 1; i <= number1; i++)
        {
            factorial *= i;
        }
        return factorial;
    }


}


