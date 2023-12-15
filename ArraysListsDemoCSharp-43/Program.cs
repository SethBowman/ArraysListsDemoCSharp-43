using System.Collections.Generic;

namespace ArraysListsDemoCSharp_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //Arrays have set size that define at creation, and that size cannot change
            var numbers = new int[5] { 100, 50, 40, 12, 5 };

            //var newListNumbers = numbers.ToList();

            //var backToArr = newListNumbers.ToArray();

            //numbers[0] = 50;

            //foreach(var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Arrays have a property called "Length" that shows you the number of things in the array
            Console.WriteLine(numbers.Length);

            var names = new string[] { "Seth", "Cruz", "Mack" };

            Console.WriteLine(names.Length);

            for(int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            //Lists
            //Lists have a size that can change all you want

            var listNumbers = new List<int>() { 2, 50, 444 };

            listNumbers.Add(20);
            listNumbers.Remove(50);

            foreach(var number in listNumbers)
            {
                Console.WriteLine(number);
            }

            //Lists have a property called Count that gets the number of things in the list
            //Console.WriteLine(listNumbers.Count);


            var students = new List<string>() { "Vernon", "Adrienne", "Dale", "Herby", "Kim", "Mack", "Philip", "Victor", "William", "Seth" };

            //Console.WriteLine(students.Count);

            students.Remove(students[9]);

            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }


        }
    }
}
