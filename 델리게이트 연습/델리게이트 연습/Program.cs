namespace 델리게이트_연습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";
            string vowels = "aeoiuAEOIU";

            foreach (char vowel in vowels)
            { 
                text =text.Replace(vowel.ToString(),"");
            }

            Console.WriteLine(text);
        }

    }
}
