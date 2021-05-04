using System;
using System.Collections.Generic;
using System.IO;

namespace WhatILearned
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Beers.csv");
            List<Beer> Kegs = new List<Beer>();
            string ingredients;
            string[] ingredientList;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] breaks = lines[i].Split(",");

                Beer B = new Beer();

                B.BeerName = breaks[0];
                B.ABV = Convert.ToDouble(breaks[1]);
                B.Calories = Convert.ToDouble(breaks[2]);
                B.Carbs = Convert.ToDouble(breaks[3]);
                B.Proteins = Convert.ToDouble(breaks[4]);
                ingredients = breaks[5];
                B.Ingredients = ingredients;
                ingredientList = ingredients.Split(";");
                foreach (string ing in ingredientList)
                {
                    B.AddIngredients(ing);
                }

                Kegs.Add(B);
            }

            Console.WriteLine("Do you want an alcoholic beer? (yes or no)>>");
            string answer = Console.ReadLine().ToLower();
            if (answer[0] == 'n')
            {
                Console.WriteLine("Try this non-alcoholic beer!");
                Console.WriteLine(Kegs[5]);
                return;
            }
            else
            {
                Console.WriteLine("Party on dude");
            }
            Console.WriteLine("Would you prefer a low calorie beer? (yes or no)>>");
            answer = Console.ReadLine().ToLower();
            if (answer[0] == 'y')
            {
                Console.WriteLine("Try these low-cal beers!");
                foreach (Beer beer in Kegs)
                {
                    if (beer.Calories <= 100)
                    {
                        Console.WriteLine(beer.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("These beers are over 100 calories:");
                foreach (Beer beer in Kegs)
                {
                    if (beer.Calories > 100)
                    {
                        Console.WriteLine(beer.ToString());
                    }
                }
            }
            Console.WriteLine("Are you allergic to any citrus fruit? (yes or no)>>");
            answer = Console.ReadLine().ToLower();
            if (answer[0] == 'y')
            {
                Console.WriteLine("You can drink these beers!");
                foreach (Beer beer in Kegs)
                {
                    if (beer.IsThereCitrus() == false)
                    {
                        Console.WriteLine(beer.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("You should try these beers!");
                foreach (Beer beer in Kegs)
                {
                    if (beer.IsThereCitrus() == true)
                    {
                        Console.WriteLine(beer.ToString());
                    }
                }
            }
        }
    }
}
