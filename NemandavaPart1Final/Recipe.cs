﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemandavaPart1Final
{
    internal class Recipe
    {
        //storing ingredient and steps in arrays 
        public Ingredient[] Ingredients { get; set; }
        public string[] Steps { get; set; }

        private int ingredientIndex = 0;
        private int stepIndex = 0;

        public Recipe(int ingredientCount, int stepCount)
        {
            Ingredients = new Ingredient[ingredientCount];
            Steps = new string[stepCount];
        }
        public void AddIngredient(string name, double quantity, string unit)
        {
            Ingredients[ingredientIndex++] = new Ingredient(name, quantity, unit);
        }

        public void AddStep(string step)
        {
            Steps[stepIndex++] = step;
        }
       
        public void DisplayRecipe()//dispalying method
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }
        public void ScaleRecipe(double factor)//scalling method 
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
        public void ResetQuantities()//reseting method
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity = ingredient.OriginalQuantity;
            }
        }
        public void ClearRecipe() //clearing method
        {
            Ingredients = new Ingredient[Ingredients.Length];
            Steps = new string[Steps.Length];
        }

    }

}

