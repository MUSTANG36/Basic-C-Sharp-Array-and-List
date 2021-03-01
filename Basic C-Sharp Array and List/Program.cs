using System;
using System.Collections.Generic;

namespace Basic_C_Sharp_Array_and_List
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /*
         When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        If no one likes your post, it doesn't display anything.
        If only one person likes your post, it displays: [Friend's Name] likes your post.
        If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
        Depending on the number of names provided, display a message based on the above pattern.

         */

        static void Exercise1() {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name");
                var input = Console.ReadLine();


                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                names.Add(input);
            }


            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }
        /*
        Write a program and ask the user to enter their name.
        Use an array to reverse the name and then store the result in a new string. 
        Display the reversed name on the console.
        */
        static void Exercise2()
        {
            Console.WriteLine("Enter your name");
            var input = Console.ReadLine();

            var arr1 = input.ToCharArray();
            Array.Reverse(arr1);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + ",");
            }
        }
        /*
       Write a program and ask the user to enter 5 numbers. 
        If a number has been previously entered, display an error message and ask the user to re-try. 
        Once the user successfully enters 5 unique numbers, sort them and display the result on the console
       */
        static void Exercise3()
        {
            var list = new List<int>();

            while (list.Count < 5)
            {
                Console.WriteLine("Enter 5 non-repeatable numbers.");
                var num = Convert.ToInt32(Console.ReadLine());

                if (list.Contains(num))
                {
                    Console.WriteLine("Error you have enter the number aready");
                    //break;
                    continue;
                }


                list.Add(num);

            }

            list.Sort();

            foreach (var i in list)
            {
                Console.Write(i);
            }
        }
        /*
       Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        The list of numbers may include duplicates. Display the unique numbers that the user has entered.
       */
        static void Exercise4()
        {
            var numbers = new List<int>();

            while (true)
            {

                Console.WriteLine("Enter a number or Quit to quit.");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            //make two list. Oraignal and Unique, compare the two

            var unique = new List<int>();

            foreach (var x in numbers)
            {
                if (!unique.Contains(x))
                {
                    //unique[i]
                    unique.Add(x);
                }
            }
            Console.WriteLine("Unique numbers:");
            foreach (var x in unique)
                Console.WriteLine(x);
        }
        /*
        Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
        If the list is empty or includes less than 5 numbers, 
        display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
       */
        static void Exercise5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }




    }
}
