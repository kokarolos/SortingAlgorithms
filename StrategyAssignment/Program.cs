using StrategyAssignment;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Shirts");
            var shirts = DataLoader.GenerateTShirts().ToArray();
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }

            Console.WriteLine("\n\n\n");
            SortingMethod bubbleSort = new BubbleSort();
            SortingMethod bucketSort = new BucketSort();
            SortingMethod quickSort = new QuickSort();

            DisplayManager displayManager = new DisplayManager();

            DisplayManager.DisplayBySizeAsc(quickSort, shirts);
            Console.WriteLine();
            DisplayManager.DisplayBySizeDesc(quickSort, shirts);
            Console.WriteLine();
            DisplayManager.DisplayByColorAsc(bucketSort, shirts);
            Console.WriteLine();
            DisplayManager.DisplayByColorDesc(quickSort, shirts);
            Console.WriteLine();
            DisplayManager.DisplayByFabricAsc(bubbleSort, shirts);
            Console.WriteLine();
            DisplayManager.DisplayByFabricDesc(bubbleSort, shirts);
            Console.WriteLine();
            DisplayManager.DisplayBySizeColorFabricAsc(bubbleSort, shirts);
            Console.WriteLine();
            DisplayManager.DisplayBySizeColorFabricDesc(bubbleSort, shirts);


        }

    }
}
    
