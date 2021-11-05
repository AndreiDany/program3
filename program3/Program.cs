using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti textul!");
            string text;
            text = Console.ReadLine();
            
            for(int i=0; i<text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
            Console.WriteLine("\n");
            for (int i = text.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(text[i]);
            }
            int c = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                    c++;
                    
            }
            Console.WriteLine(c);


        }
    }
}
