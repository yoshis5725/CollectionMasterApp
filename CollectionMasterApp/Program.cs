using System;
using System.Collections.Generic;
using System.Linq;
namespace CollectionMasterApp
{
    class Program
    {

        public static int[] PopulateNumbersArray(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Random rand = new Random();
                int randNum = rand.Next(1, 50);
                numbersArray[i] = randNum;
            }

            return numbersArray;
        }


        public static void NumberPrinter(int[] numbersArray)
        {
            foreach (int num in numbersArray)
            {
                Console.Write($"{num} ");
            }
        }


        public static void NumberPrinter(List<int> numbersList)
        {
            foreach (int num in numbersList)
            {
                Console.Write($"{num} ");
            }
        }


        public static void Multiple3to0(int[] numbersArray)
        {
            int[] multipleOf3 = new int[50];
            foreach (int num in numbersArray)
            {
                if (num % 3 == 0)
                {
                    multipleOf3[num] = 0;
                }
                else
                {
                    multipleOf3[num] = num;
                }

                Console.Write($"{multipleOf3[num]} ");
            }
        }


        public static void PopulateList(List<int> integerList)
        {
            for (int i = 0; i < 50; i++)
            {
                Random rnd = new Random();
                int randomNumbers = rnd.Next(1, 50);
                integerList.Add(randomNumbers);
            }
        }


        public static void SearchEnteredNumber(string enteredNumber, List<int> integerList)
        {
            if (int.TryParse(enteredNumber, out int queriedNumber))
            {
                foreach (int num in integerList)
                {
                    if (num == queriedNumber)
                    {
                        Console.Write(" **True** ");
                    }
                    else
                    {
                        Console.Write(" False ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a digit");
            }
        }


        public static void DisplayEvenList(List<int> integerList)
        {
            List<int> evenList = new List<int>();

            foreach (int num in integerList)
            {
                if (num % 2 == 0)
                {
                    evenList.Add(num);
                }
            }

            foreach (int num in evenList)
            {
                Console.Write($"{num} ");
            }
        }


        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbersArray = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            PopulateNumbersArray(numbersArray);

            //TODO: Print the first number of the array
            Console.WriteLine($"First number in the array ----> {numbersArray[0]}");

            //TODO: Print the last number of the array
            Console.WriteLine($"Last number in the array ----> {numbersArray[49]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            int[] reverseNumbersArray = numbersArray.Reverse().ToArray();
            foreach (int num in reverseNumbersArray)
            {
                Console.Write($"{num} ");
            }


            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            Multiple3to0(numbersArray);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbersArray);
            foreach (int num in numbersArray)
            {
                Console.Write($"{num} ");
            }



            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> integerList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine(integerList.Count());

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            PopulateList(integerList);

            //TODO: Print the new capacity
            Console.WriteLine(integerList.Count());


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string enteredNumber = Console.ReadLine();
            SearchEnteredNumber(enteredNumber, integerList);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(integerList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            DisplayEvenList(integerList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            integerList.Sort();

            foreach (int num in integerList)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] convertToArray = integerList.ToArray();

            //TODO: Clear the list
            integerList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {

        }

        private static void OddKiller(List<int> numberList)
        {

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }

        private static void ReverseArray(int[] array)
        {

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }

}
