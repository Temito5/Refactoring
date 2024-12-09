using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    internal class Program
    {
        public static List<int> SplitList(List<int> originalList, string type)
        {
            List<int> newList = new List<int>();

            foreach (var item in originalList)
            {
                if (type == "even" && item % 2 == 0)
                {
                    newList.Add(item);
                }
                else if (type == "odd" && item % 2 != 0)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
        static void Main(string[] args)
        {
            List<int> originalList = new List<int>(); 

            originalList.Add(1);
            originalList.Add(2);
            originalList.Add(3);
            originalList.Add(4);
            originalList.Add(5);

            var evenList = SplitList(originalList, "even");
            var oddList = SplitList(originalList, "odd");

            Console.WriteLine("Списък с четни числа:");
            foreach (var item in evenList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Списък с нечетни числа:");
            foreach (var item in oddList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
