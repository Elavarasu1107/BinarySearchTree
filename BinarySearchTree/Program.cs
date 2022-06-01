using System;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Creating BTS\n 2 for Size Method BTS");
            Console.WriteLine("Enter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);

            switch (userInput)
            {
                case 1:
                    {
                        binarySearch.Insert(30);
                        binarySearch.Insert(70);
                        binarySearch.Display();
                        break;
                    }
                case 2:
                    {
                        binarySearch.Insert(30);
                        binarySearch.Insert(70);
                        binarySearch.Insert(22);
                        binarySearch.Insert(40);
                        binarySearch.Insert(60);
                        binarySearch.Insert(95);
                        binarySearch.Insert(11);
                        binarySearch.Insert(65);
                        binarySearch.Insert(3);
                        binarySearch.Insert(16);
                        binarySearch.Insert(63);
                        binarySearch.Insert(67);
                        binarySearch.Display();
                        binarySearch.GetSize();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Valid Number");
                        break;
                    }
            }   
        }
    }
}
