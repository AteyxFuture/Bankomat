using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Bankomat

{

    class Program

    {

        static void Main(string[] args)

        {

            float castka, zbytek;

            float petitisicovka = 5000;

            float a;

            float dvoutisicovka = 2000;

            float b;

            float tisicovka = 1000;

            float c;

            float petistovka = 500;

            float d;

            float dvoustovka = 200;

            float e;

            float stovka = 100;

            float f;



            Console.WriteLine("Tento program slouzi ke zjisteni, jake bankovky by vam byly vyplaceny, pokud byste pozadali o urcitou castku.");

            Console.WriteLine("Jakou castku si prejete vyplatit?");

            castka = float.Parse(Console.ReadLine());

            zbytek = castka;



            zbytek =castka % petitisicovka;

            a = (castka - zbytek) / petitisicovka;

            castka = zbytek;

            zbytek = castka % dvoutisicovka;

            b = (castka - zbytek) / dvoutisicovka;

            castka = zbytek;

            zbytek = castka % tisicovka;

            c = (castka - zbytek) / tisicovka;

            castka = zbytek;

            zbytek = castka % petistovka;

            d = (castka - zbytek) / petistovka;

            castka = zbytek;

            zbytek = castka % dvoustovka;

            e = (castka - zbytek) / dvoustovka;

            castka = zbytek;

            zbytek = castka % stovka;

            f = (castka - zbytek) / stovka;

            castka = zbytek;



            Console.WriteLine("Bude Vam vyplaceno:");

            Console.WriteLine("Petitisicovky: "+a);

            Console.WriteLine("Dvoutisicovky: "+b);

            Console.WriteLine("Tisicovky: "+c);

            Console.WriteLine("Petistovky: "+d);

            Console.WriteLine("Dvoustovky: "+e);

            Console.WriteLine("Stovky: "+f);

            Console.WriteLine("Nevyplatitelny zbytek: " + castka);

        }

    }

}
