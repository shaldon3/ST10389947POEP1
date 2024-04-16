using RecipeApp;

class Recipe
{
    private Ingredients[] ingredients;
    private RecipeStep[] steps;

    public Recipe(int ingredientCount, int stepCount)
    {
        ingredients = new Ingredients[ingredientCount];
        steps = new RecipeStep[stepCount];
    }

    public void AddIngredient(int index, string name, double quantity, string unit)
    {
        // Store original quantity when ingredient is added
        ingredients[index] = new Ingredients { Name = name, OriginalQuantity = quantity, Quantity = quantity, Unit = unit };
    }

    public void AddStep(int index, string description)
    {
        steps[index] = new RecipeStep { Description = description };
    }

    public void DisplayRecipe()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Recipe:");

        Console.WriteLine("Ingredients:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
        }

        Console.WriteLine("Steps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i].Description}");
        }

        Console.ForegroundColor = ConsoleColor.White; // Reset color to default
    }

    public void Scale(double factor)
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    public void Reset()
    {
        // Reset quantities to original values
        foreach (var ingredient in ingredients)
        {
            // Reset quantity to original quantity
            ingredient.Quantity = ingredient.OriginalQuantity;
        }
    }
}
