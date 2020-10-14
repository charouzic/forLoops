using System;
using System.Collections;

// needs to be imported in order to init arrays without size definition
using System.Collections.Generic; 

namespace exercise6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            // 1. printing numbers from 51 to 100
            for (int counter = 51; counter <= 100; ++counter)
                {
                Console.Write($"{counter}, ");
                }
            Console.WriteLine();


            // 2. printing odd numbers from 1 to 999
            for (int counter = 1; counter <= 999; counter+=2)
            {
                Console.Write($"{counter}, ");
            }
            Console.WriteLine();


            // 3. printing reversed pyramid from stars
            for (string str = "*****"; str.Length >= 1; )
            {
                Console.WriteLine(str);
                str = str.Remove(str.Length - 1);
            }

            // 4. printing inverted pyramid from numbers
            for (string numbs = "1234567890"; numbs.Length >=1; numbs = numbs.Remove(numbs.Length-1))
                {
                    Console.WriteLine(numbs);
                }


            // 5. printing normal centred pyramid
            //int pyramidRowCount = 4;
            for (int n = 1; n<=10; ++n)
            {
                if (n==1)
                {
                    Console.WriteLine($"   {n}");
                }
                if (n==2)
                {
                    Console.Write($"  {n}");
                }
                if (n == 3)
                {
                    Console.WriteLine($" {n}");
                }
                if (n == 4)
                {
                    Console.Write($" {n}");
                }
                if (n == 5)
                {
                    Console.Write($" {n}");
                }
                if (n == 6)
                {
                    Console.WriteLine($" {n}");
                }
                if (n == 7)
                {
                    Console.Write($"{n}");
                }
                if (n == 8)
                {
                    Console.Write($" {n}");
                }
                if (n == 9)
                {
                    Console.Write($" {n}");
                }
                if (n == 10)
                {
                    Console.Write($" {n}");
                }
            }


            // 6. array of 10 country names, assign randomly and print
            // values using for loop

            string[] countries = new string[10];
            countries[0] = "Czechia";
            countries[1] = "Denmark";
            countries[2] = "Sweeden";
            countries[3] = "Norway";
            countries[4] = "Finland";
            countries[5] = "Lithuania";
            countries[6] = "Portugal";
            countries[7] = "Spain";
            countries[8] = "Italy";
            countries[9] = "Germany";

            for (int counter = 0; counter < countries.Length; ++counter)
            {
                Console.WriteLine($"Country: {countries[counter]}");
            }
            

            
            // 7. seven integer  element, initialize element one by one,
            // print elements without any for loop
            int[] nums = new int[7];
            nums[0] = 1;
            nums[1] = 11;
            nums[2] = 111;
            nums[3] = 1111;
            nums[4] = 11111;
            nums[5] = 111111;
            nums[6] = 1111111;

            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[3]);
            Console.WriteLine(nums[4]);
            Console.WriteLine(nums[5]);
            Console.WriteLine(nums[6]);
            

            
            // 8. array type string called Fruits, print all elements using
            // while loop and foreach loop
            string[] Fruits = {"Apple", "Orange", "Banana", "Pear", "Peach"};

            // while loop
            int lenght = 0;
            while (lenght <= 4)
            {
                Console.WriteLine(Fruits[lenght]);
                ++lenght;
            }

            // for-each loop
            foreach (string fruit in Fruits)
            {
                Console.WriteLine(fruit);
            }
            


            

            // 9. array type of string called arrCityNames,
            // assign 10 names to the list,
            // print elements using for and foreach loop

            //string[] arrCityNames;
            List<string> arrCityNames = new List<string>();

            arrCityNames.Add("Copenhagen");
            arrCityNames.Add("Roskilde");
            arrCityNames.Add("Prague");
            arrCityNames.Add("Opocno");
            arrCityNames.Add("Liberec");
            arrCityNames.Add("Hradec Kralove");
            arrCityNames.Add("Aarhus");
            arrCityNames.Add("Vagar");
            arrCityNames.Add("San Jose");
            arrCityNames.Add("Los Angeles");

            
            Console.WriteLine("Using FOR-EACH loop:");
            foreach (string c in arrCityNames)
            {
                Console.WriteLine(c);
            }
            
            Console.WriteLine("Using FOR loop:");
            for (int i = 0; i<arrCityNames.Count; ++i)
            {
                Console.WriteLine(arrCityNames[i]);
            }
           
            

        }
    }
}
