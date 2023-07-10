using System;
using System.Text;

namespace AcademyProject_String_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the phrase: ");
            string phrase = Console.ReadLine();

            int len = phrase.Length;
            StringBuilder newPhrase = new StringBuilder(phrase);

            for (int i = 0; i < len; i++)
            {
                newPhrase[i] = char.Parse(phrase[len - i - 1].ToString().ToUpper());
            }

            string finalString = newPhrase.ToString();

            Console.WriteLine(finalString);
        }
    }
}
