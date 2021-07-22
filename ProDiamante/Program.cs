using System;
using ProDiamante.Entities;

namespace ProDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = "1080" };
            p.ProcessDoc("My Letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = "2003" };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = "3216" };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertationn");
            Console.WriteLine(c.Scan());
        }
    }
}
