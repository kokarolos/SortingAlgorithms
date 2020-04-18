using StrategyAssignment;
using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var shirts = DataLoader.GenerateTShirts().ToArray();
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }

            Console.WriteLine("\n\n\n");

            //QuickSort.SortFacade(shirts,(pivot,arrayIndex)=> pivot.Color > arrayIndex.Color);
            //foreach (var item in shirts)
            //{
            //    Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            //}
            BucketSort.Sorting(ref shirts);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }
        }

    }
}
