using System;

namespace RecipeApp
{
    class Ingredients
    {
        public string Name { get; set; }
        public double OriginalQuantity { get; set; } // Added property to store original quantity
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }

    class RecipeStep
    {
        public string Description { get; set; }
    }
}