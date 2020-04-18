using System;

namespace StrategyAssignment
{
    public class DisplayManager
    { 
        public static void DisplayBySizeAsc(SortingMethod method, TShirt[] shirts)
        {
            Console.WriteLine();
            Console.WriteLine("Size in Ascending");
            method.Sort(shirts, (pivot, arrayIndex) => pivot.Size > arrayIndex.Size);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }
        }
        public static void DisplayBySizeDesc(SortingMethod method, TShirt[] shirts)
        {
            Console.WriteLine();
            Console.WriteLine("Size in Descending");
            method.Sort(shirts, (pivot, arrayIndex) => pivot.Size < arrayIndex.Size);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }
        }
        public static void DisplayByColorAsc(SortingMethod method, TShirt[] shirts)
        {
            Console.WriteLine("Color in Ascending");
            method.Sort(shirts, null);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }
        }
        public static void DisplayByColorDesc(SortingMethod method, TShirt[] shirts)
        {
            Console.WriteLine("Color in Descending");
            method.Sort(shirts, (x,y)=>x.Color<y.Color);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }
        }
        public static void DisplayByFabricAsc(SortingMethod method, TShirt[] shirts)
        {
            Console.WriteLine("Fabric in Ascending");
            method.Sort(shirts, (currentPosition, nextPosition) => currentPosition.Fabric > nextPosition.Fabric);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");

            }
        }
        public static void DisplayByFabricDesc(SortingMethod method, TShirt[] shirts)
        {
            Console.WriteLine("Fabric in Descending");
            method.Sort(shirts, (currentPosition, nextPosition) => currentPosition.Fabric < nextPosition.Fabric);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");

            }
        }
        public static void DisplayBySizeColorFabricAsc(SortingMethod method, TShirt[] shirts)
        {
            Console.WriteLine("Size and Color and Fabric in Ascending");
            method.Sort(shirts, (pivot, arrayIndex) => pivot.Fabric > arrayIndex.Fabric);
            method.Sort(shirts, (pivot, arrayIndex) => pivot.Color > arrayIndex.Color);
            method.Sort(shirts, (pivot, arrayIndex) => pivot.Size > arrayIndex.Size);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }
        }

        public static void DisplayBySizeColorFabricDesc(SortingMethod method, TShirt[] shirts)
        {
            Console.WriteLine("Size and Color and Fabric in Descending");
            method.Sort(shirts, (pivot, arrayIndex) => pivot.Fabric < arrayIndex.Fabric);
            method.Sort(shirts, (pivot, arrayIndex) => pivot.Color < arrayIndex.Color);
            method.Sort(shirts, (pivot, arrayIndex) => pivot.Size < arrayIndex.Size);
            foreach (var item in shirts)
            {
                Console.WriteLine($"{item.Color} {item.Size} {item.Fabric}");
            }
        }
    }
}
    
