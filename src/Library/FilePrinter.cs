using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void Print(IGetTexto texto)
        {
            File.WriteAllText("Recipe.txt", texto.GetTextToPrint());
        }
    }
}