
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hidegburokolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írja be a szoba széleségét: ");
            double szam1 = int.Parse(Console.ReadLine());
            Console.Write("Írja be a szoba hosszúságát: ");
            double szam2 = int.Parse(Console.ReadLine());
            Console.Write("Írja be a szoba alapfelülete: ");
            double szelesseg = int.Parse(Console.ReadLine());

            double terulet = 2 * (szam1 * szam2) * szelesseg + szam1 * szam2;
            double teljes = terulet * 1.10;
            double csomag = 1.44;
            double csomagkell = Math.Ceiling(teljes / csomag);
            Console.WriteLine($"Ennyi csomagra lesz szükség: {csomagkell} csomag" );

            /*Console.Write("A alapterület: " + szelesseg);
            Console.WriteLine("Hosszabb oldalfal: ");
            Console.WriteLine("Rövidebb oldalfal: ");
            Console.WriteLine("A teljes: " );
            Console.WriteLine("Plusz 10%-kal nő: ");*/

            Console.ReadKey();
        }
    }
}
