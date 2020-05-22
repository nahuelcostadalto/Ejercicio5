using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(IGetTexto texto)
        {
            Console.WriteLine(texto.GetTextToPrint());
        }
    }
}