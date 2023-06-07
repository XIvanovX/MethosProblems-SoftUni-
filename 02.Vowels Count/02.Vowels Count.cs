namespace _02.Vowels_Count;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int result = GetVowelsCount(input);
        Console.WriteLine(result);


    }

    private static int GetVowelsCount(string input)
    {
        char[] vowels = new char[] { 'a', 'o', 'u', 'e', 'i', 'y' };

        int vowelsCount = 0;

        foreach (char letter in input.ToLower()) 
        {
            

            if(vowels.Contains(letter))
            {
                vowelsCount++;
            }

            
        }
        return vowelsCount;
    }
}

