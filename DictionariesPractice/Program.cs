using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax - Dictionary<key data type, value data type> dictionaryName
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {

                 { "Kerry",  90 },
                 { "Berry", 85 },
                 { "Michelle", 100 } // no common, because there is not another keyValuePair that goes after the last one.
            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch Kids" },
                {"A4", "Funyuns" } // no common, because there is not another keyValuePair that goes after the last one.
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //using the add mething, lets add drinks to our dring machine.
            /*this machine uses just a number to vend an item instead of 
              a letter number pair.*/


            //drinkmaching.add(int, "string");
            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Pepsi");
            drinkMachine.Add(12, "Dr.Pepper");
            drinkMachine.Add(13, "Coke");
            drinkMachine.Add(14, "Fante");
            drinkMachine.Add(15, "Maintain Dew");

            //Count is a PROPERTY, NOT A METHOD. Returns the size of the dicitionary
            Console.WriteLine(drinkMachine.Count);

            //We have another property called .Key
            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            //Create a dictionary for a theater coat check with 10 elements.
            //the key will be a number and the value will be the coat style.
            //print all values to the console.

            Dictionary<string, int> coatCheck = new Dictionary<string, int>()
            {
                {"Levi", 5 },
                {"Wal-Mart Brand", 6 },
                {"Kmart Brand", 7 },
                {"Sears Brand", 8 },
                { "J.C. PennyBrand",9},
                {"Macy Brand", 10 },
                {"Sean John", 11 },
                {"Tommy Hilfiger", 12 },
                {"Wranglers", 13 },
                {"Lucky Brand", 14 }
            };

            Dictionary<int, string> brandName = new Dictionary<int, string>();
            {
                brandName.Add(5, "Levi");
                brandName.Add(6, "Wal-Mart Brand");
                brandName.Add(7, "Kmart Brand");
                brandName.Add(8, "Sears Brand");
                brandName.Add(9, "J.C. PennyBrand");
                brandName.Add(10, "Macy Brand");
                brandName.Add(11, "Sean John");
                brandName.Add(12, "Tommy Hilfiger");
                brandName.Add(13, "Wranglers");
                brandName.Add(14, "Lucky Brand");

                //Count is a PROPERTY, NOT A METHOD. Returns the size of the dicitionary
                Console.WriteLine(brandName.Count);

                //We have another property called .Key
                foreach (KeyValuePair<int, string> brand in brandName )
                {
                    Console.WriteLine(brand.Key);
                }

                foreach (KeyValuePair<int, string> brand in brandName)
                {
                    Console.WriteLine(brand.Value);

                }

                /*Creat a dictionary for a car valet service with 10 cars.
                 The key will be the customers, last name and the value
                 will be the carmake. Print all keys to the console.*/



                /* Create a dictionary of 10 zoo animals. The key will be 
                 the animal type the value will be the number of that animals 
                 type at the zoo. print the animal with the highest quality
                 to the console. */


                Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
                {
                    { "Lion", 1 },
                    { "Zebra", 2 },
                    { "Tiger", 3 },
                    { "Giraffe", 4 },
                    { "Monkey", 5 },
                    {"Bird",6},
                    {"Otter", 7 },
                    {"Gorilla", 8 },
                    {"Snake", 9 },
                    {"Deer", 10 }

                };

                int highest = 0;
                foreach(KeyValuePair<string, int> animal in zooAnimals)
                {
                   if(animal.Value > highest)
                    {
                        highest = animal.Value;
                    }
                    
                }

                
                foreach(KeyValuePair<string, int> animal in zooAnimals)
                {
                    if (animal.Value == highest)
                    {
                        Console.WriteLine(animal.Key);
                    }

                }
            
                
            }
        }
    }
}
