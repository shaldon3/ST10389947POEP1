
using System;
using RecipeApp;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta; // Set menu font color to purple
        Console.WriteLine("Welcome to Recipe App!");

        // Initialize variables to store recipe details
        int ingredientCount, stepCount;
        Recipe recipe = null;

        // Menu loop
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Enter recipe details");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset quantities");
            Console.WriteLine("5. Clear recipe");
            Console.WriteLine("6. Exit");

            Console.ForegroundColor = ConsoleColor.White; // Reset font color for user input
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nEnter the number of ingredients:");
                    ingredientCount = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the number of steps:");
                    stepCount = int.Parse(Console.ReadLine());

                    recipe = new Recipe(ingredientCount, stepCount);

                    for (int i = 0; i < ingredientCount; i++)
                    {
                        Console.WriteLine($"Enter ingredient {i + 1} name:");
                        string name = Console.ReadLine();

                        Console.WriteLine($"Enter ingredient {i + 1} quantity:");
                        double quantity = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Enter ingredient {i + 1} unit of measurement:");
                        string unit = Console.ReadLine();

                        recipe.AddIngredient(i, name, quantity, unit);
                    }

                    for (int i = 0; i < stepCount; i++)
                    {
                        Console.WriteLine($"Enter step {i + 1} description:");
                        string description = Console.ReadLine();

                        recipe.AddStep(i, description);
                    }
                    break;

                case "2":
                    if (recipe != null)
                        recipe.DisplayRecipe();
                    else
                        Console.WriteLine("No recipe details entered yet.");
                    break;

                case "3":
                    if (recipe != null)
                    {
                        Console.WriteLine("Enter a scaling factor (0.5, 2, 3):");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.Scale(factor);
                    }
                    else
                        Console.WriteLine("No recipe details entered yet.");
                    break;

                case "4":
                    if (recipe != null)
                        recipe.Reset();
                    else
                        Console.WriteLine("No recipe details entered yet.");
                    break;

                case "5":
                    recipe = null;
                    Console.WriteLine("Recipe cleared.");
                    break;

                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.ForegroundColor = ConsoleColor.Green; // Set output font color to green
        Console.WriteLine("Thank you for using Recipe App!");
        Console.ForegroundColor = ConsoleColor.White; // Reset font color to default
    }
}
