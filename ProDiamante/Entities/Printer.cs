using System;
using System.Collections.Generic;
using System.Text;

namespace ProDiamante.Entities
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processeing: " + doc);
        }

        public void Print(string doc)
        {
            Console.WriteLine("Printer print: " + doc);
        }
    }
}
