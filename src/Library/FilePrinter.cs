using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe()
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
        public IText recipe;
        public FilePrinter(IText text)
        {
            this.recipe = text;
        }
    }
}