using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses_Lab___02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');
            
            List<string> shuffledWords = new List<string>();

            Random random = new Random();

            foreach (var word in words)
            {
                shuffledWords.Insert(random.Next(0, shuffledWords.Count + 1), word);
            }

            foreach (var word in shuffledWords)
            {
                Console.WriteLine(word);
            }



        }
    }
}
