using System;
using System.Collections.Generic;
using System.Linq;
namespace MyApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            /*
            int[] array = { 2, 4, 1, 3, 90, 654, 900, 1024, 96, 51 };
            IEnumerable<int> query1 =  from i in array
                                     where i % 2 == 0
                                     select i;
            IEnumerable<int> query2 = from i in array
                                     where i % 2 == 1
                                     select i;
            Console.WriteLine("четные:");
            foreach (var el in query1)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("нечетные:");
            foreach (var el in query2)
            {
                Console.WriteLine(el);
            }*/
            /*
            string str = "Привет! Это голосовой помощник Олег! Оставьте свое сообщение!";
            var wordsWithOorT = str.Split(new[] { ' ', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Where(word => word.Contains('о') || word.Contains('т'));

            Console.WriteLine("Слова с буквой 'о' или 'т':");
            foreach (var word in wordsWithOorT)
            {
                Console.WriteLine(word);
            }

            var wordsEndsWithEorK = str.Split(new[] { ' ', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Where(word => word.EndsWith('е') || word.EndsWith('к'));

            Console.WriteLine("Слова, оканчивающиеся на 'е' или 'к':");
            foreach (var word in wordsEndsWithEorK)
            {
                Console.WriteLine(word);
            }
            */
        }
    }
}