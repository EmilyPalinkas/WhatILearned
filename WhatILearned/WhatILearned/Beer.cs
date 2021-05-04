using System;
using System.Collections.Generic;
using System.Text;

namespace WhatILearned
{
    public class Beer
    {
        public string BeerName { get; set; }

        public double ABV { get; set; }

        public double Calories { get; set; }

        public double Carbs { get; set; }

        public double Proteins { get; set; }
        public string Ingredients { get; set; }

        public List<string> IngredientList { get; set; }

        public Beer()
        {
            BeerName = "";
            Calories = 0;
            Carbs = 0;
            Proteins = 0;
            Ingredients = "";
            IngredientList = new List<string>();
        }
        public override string ToString()
        {
            return $"{BeerName} : ABV% - {ABV}, Calories - {Calories}, Carbs - {Carbs}, Protein - {Proteins}, Ingredients - {Ingredients}";
        }
        public void AddIngredients(string ing)
        {
            IngredientList.Add(ing);
        }
        public bool IsThereCitrus()
        {
            foreach (string ing in IngredientList)
            {
                if ((ing.ToLower() == "lime peel") | (ing.ToLower() == "orange peel"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
