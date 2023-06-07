namespace _05.Add_and_Subtract;
class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int result = FirstTwoDigitsMinusThird(num1, num2,num3);
        Console.WriteLine(result);
       
    }

    static int DigitsAdded(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    static int FirstTwoDigitsMinusThird(int num1,int num2,int num3)
    {
        int result = DigitsAdded(num1, num2) - num3;

        return result;
    }


}

