namespace _06.Middle_Characters;
class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();


        MiddleCharacters(text);
        


    }

    static void MiddleCharacters(string text)
    {
        int textLenght = text.Length;
        int middleText = textLenght / 2;

        if(textLenght%2==0)
        {
            Console.WriteLine($"{text[middleText - 1]}{text[middleText]}");
        }
        else
        {
            Console.WriteLine($"{text[middleText]}");
        }

       
    }
}

