using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your String To Split");
            string userInput = Console.ReadLine();
            // Split string on spaces.
            // ... This will separate all the words.
            Console.WriteLine("\n");

            Console.WriteLine("Splited Words Are:");

            string[] words = userInput.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
                
            }

            Console.ReadLine();
        }
    }
    
}
