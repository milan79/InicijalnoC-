using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 4 interpolacija stringova
            string preyime = "Radovanovic", ime= "Milan";
            Console.WriteLine($"Zdravo, {ime} {preyime.ToUpper()}");

            //Step 5 - integer tip
            int x = 10;
            int y = 8;
            int z = x + y;
            Console.WriteLine($"{x}+{y}={z}");
            z = x / y;
            Console.WriteLine($"{ x}/{ y}={ z}");
            int minimalnavrednost = int.MinValue;
            int maksimalnavrednost = int.MinValue;
            Console.WriteLine($"Opseg vrednosti za INT tip je od {minimalnavrednost} do {maksimalnavrednost}");

            //Step 6 - double tip

            double xx = 10;
            double yy = 8;
            double zz = xx + yy;
            Console.WriteLine($"Rezultat od {xx}+{yy} je {zz}");
            zz = xx / yy;
            Console.WriteLine($"Rezultat od {xx}/{yy} je {zz}");

            // povrsina kruga
            double r = 2.50;
            double p = r * r * Math.PI;
            Console.WriteLine($"Povrsina kruga sa poluprecnikom {r} je {p}");

            //obim kruga
            // pre kraja
            string ulaz = Console.ReadLine();
            r = Convert.ToDouble(ulaz);
            //ili drugacije *krace
            // r = Convert.ToDouble(Console.ReadLine());
            double o = 2 * r * Math.PI;
            Console.WriteLine($"Obim kruga sa poluprecnikom {r} je {o}");
            
        }
    }
}
