
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
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Írja be a szoba magassága: ");
            byte szam2 = int.Parse(Console.ReadLine());
            Console.Write("Írja be a szoba hosszúságát: ");
            int szam3 = int.Parse(Console.ReadLine());
            Console.Write("Írja be a szoba felületét: ");
            int szam4 = int.Parse(Console.ReadLine());
            Console.WriteLine(szam1 + szam3 / szam2 * szam4);
            Console.ReadKey();
        }
    }
}
