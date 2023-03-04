using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBL;

namespace _28._02._2023_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDict = new Dictionary<string, string>();
            myDict.Add("Ukraine", "Украина");
            myDict.Add("Poland", "Польша");
            myDict.Add("Germany", "Германия");
            myDict.Add("USA", "США");

            var ChoiceDict = new MenuByList("Choice Dictionary: ",
                "English-Russian",
                "Russian-English"
            );

            var sortedDict = new SortedDictionary<string, string>();
            switch (ChoiceDict.GetChise())
            {
                case 0: foreach (var item in myDict) sortedDict.Add(item.Key, item.Value); break;
                case 1: foreach (var item in myDict) sortedDict.Add(item.Value, item.Key); break;
            }

            Console.Write("\n\tWrite contry name: ");
            string word = Console.ReadLine();
            try { Console.WriteLine($"\tResult: {sortedDict[word]}"); }
            catch { Console.WriteLine("\tIt's not in my data."); }

            Console.ReadKey();
        }
    }
}
