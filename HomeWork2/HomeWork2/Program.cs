using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>() { 1, 2, 3 };
            foreach (var item in customList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_____________________________");
            foreach (var item in customList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_____________________________");
            customList.RemoveAt(0);
            foreach (var item in customList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
