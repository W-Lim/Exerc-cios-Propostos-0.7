using System;
using System.Collections.Generic;
using System.Text;

namespace ProDiamante.Entities
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine("ComboDevisse Print " + doc) ;
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Combodevice processing " + doc);
        }

        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
