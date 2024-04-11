using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of ingredients: ");
        int ingredientCount = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of steps: ");
        int stepCount = int.Parse(Console.ReadLine());

        Recipe recipe = new Recipe(ingredientCount, stepCount);

        for (int i = 0; i < ingredientCount; i++)
        {
            Console.Write($"Enter the name of ingredient {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter the quantity of {name}: ");
            double quantity = double.Parse(Console.ReadLine());

            Console.Write($"Enter the unit of measurement for {name}: ");
            string unit = Console.ReadLine();

            recipe.AddIngredient(name, quantity, unit);
        }

        for (int i = 0; i < stepCount; i++)
        {
            Console.Write($"Enter step {i + 1}: ");
            string step = Console.ReadLine();

            recipe.AddStep(step);
        }

        recipe.DisplayRecipe();

       
    }
}
