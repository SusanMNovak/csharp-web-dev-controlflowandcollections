using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //2. Within Main, create a list with at least 10 integers and call your method on the list.

            List<int> someIntegers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int total = sumEven(someIntegers);

            Console.WriteLine(total);

            List<string> Line = PrintWordList();

            foreach (string word in Line)
            {

                Console.WriteLine(word);
            }

            int length = 0;
            Console.WriteLine("Word length?");
            length = int.Parse(Console.ReadLine());

            PrintXLettersWord(PrintWordList(), length);

            }

        //1. Write a static method to find the sum of all the even numbers in a List.

        public static int sumEven(List<int> arr)
        {
            int total = 0;
            foreach (int integer in arr)

                if (integer % 2 == 0)
                {
                    total += integer;
                }
            return total;
        }



        //3. Write a static method to print out each word in a list that has exactly 5 letters.

        public static List<string> PrintWordList()
        {
            string phrase = "C# is a great programming language.";
            List<string> wordList = new List<string>();
            string[] newStr = phrase.Split(" ");
            foreach (string word in newStr)
            {
                wordList.Add(word);
           }

            return wordList;
        }

        //4. Modify your code to prompt the user to enter the word length for the search.

        public static void PrintXLettersWord(List<string> wordList, int length)
        {
            

            foreach (string word2 in wordList)
            {
                if (word2.Length == length)
                {
                    Console.WriteLine(word2);


                }
            }
        }
    }
}