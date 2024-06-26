﻿using NemandavaPart1Final;
using System;


class Program
{ 
    static void Main(string[] args)
    {
        try
        {
            // Getting details for a sing recipe
            Console.WriteLine("**Sanele app**");
            Console.Write("Enter the number of ingredients: ");
        int ingredientCount = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of steps: ");
        int stepCount = int.Parse(Console.ReadLine());

        Recipe recipe = new Recipe(ingredientCount, stepCount);


        for (int i = 0; i < ingredientCount; i++) //for loop
        {
            Console.Write($"Enter the name of ingredient {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter the quantity of {name}: ");
            double quantity = double.Parse(Console.ReadLine());

            Console.Write($"Enter the unit of measurement for {name}: ");
            string unit = Console.ReadLine();

            recipe.AddIngredient(name, quantity, unit);
        }

        for (int i = 0; i < stepCount; i++) //for loop
        {
            Console.Write($"Enter step {i + 1}: ");
            string step = Console.ReadLine();

            recipe.AddStep(step);
        }

        recipe.DisplayRecipe();

        while (true) // while loop for the menu display
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Scale recipe");
            Console.WriteLine("2. Reset quantities");
            Console.WriteLine("3. Clear recipe");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                    double factor = double.Parse(Console.ReadLine());
                    recipe.ScaleRecipe(factor);
                    recipe.DisplayRecipe();
                    break;
                case 2:
                    recipe.ResetQuantities();
                    recipe.DisplayRecipe();
                    break;
                case 3:
                    recipe.ClearRecipe();
                    Console.WriteLine("Recipe cleared.");
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;

            }
        }
    }
        // invalid numbers
        catch (FormatException)
        {
            Console.WriteLine("Invalid input.Enter a correct number");

        }
        //correct number length
        catch (OverflowException)
        {
            Console.WriteLine("Number is not in the correct length for the expected format.");
        }
        //for any other exception
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

  