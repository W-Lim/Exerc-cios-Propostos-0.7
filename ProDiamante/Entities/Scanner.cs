using System;
using System.Collections.Generic;
using System.Text;

namespace ProDiamante.Entities
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processeing: " + doc);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
