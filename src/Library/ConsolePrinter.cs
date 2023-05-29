using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe()
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
        public IText recipe;
        public ConsolePrinter(IText text)
        {
            this.recipe = text;
        }
    }
}