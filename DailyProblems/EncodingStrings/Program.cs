using System;

namespace EncodingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();   //AAAABBCCAA
            char letter;
            int a = 65;
            int count = 0;
            for (int i = 0; i < 26; i++)
            {
                letter = Convert.ToChar(i + a);
                if (input.Contains(letter))
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j].Equals(letter))
                        {
                            count++;
                        }
                    }
                    Console.Write($"{count}{letter}");
                    count = 0;
                }
            }
            Console.WriteLine();
        }
    }
}
