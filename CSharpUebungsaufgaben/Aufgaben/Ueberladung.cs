using System;
namespace CSharpUebungsaufgaben.Aufgaben
{
    public class Ueberladung
    {
        public Ueberladung()
        {

            void UeberladungAufgaben()
            {
                CBruch a = new CBruch(1, 2);
                CBruch b = new CBruch(1);
                CBruch c = new CBruch();
                b.Add(a, c);
                Console.WriteLine("Punkt B: " + b.Zaehler + " / " + b.Nenner);
            }
        }
    }
}
