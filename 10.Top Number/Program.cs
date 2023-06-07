namespace _10.Top_Number;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        FindTopNumbers(number);

        



    }

    static void FindTopNumbers(int number)
    {
        for(int i=1;i<=number;i++)
        {

            int originalValue = i;

            int sum = 0;
              // Take the absolute value of the number

            while (originalValue != 0)
            {
                int digit = originalValue % 10;
                sum += digit;
                originalValue /= 10;
            }

            bool isTrue = false;

            string intString = Math.Abs(sum).ToString();

            int[] digitsArray = new int[intString.Length];


            for (int j = 0; j <digitsArray.Length; j++)
            {
                char digitChar = intString[j];
                digitsArray[j] = int.Parse(digitChar.ToString());
            }



            foreach (int n in digitsArray)
            {
                if (n % 2 != 0)
                {
                    isTrue = true;
                }
            }

            if (sum % 8 == 0 && isTrue)
            {
                Console.WriteLine(i);
            }
        }
    }
}

