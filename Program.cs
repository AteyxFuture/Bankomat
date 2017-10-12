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

            float castka, castka2;

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

            castka2 = castka;



            castka =castka2 % petitisicovka;

            a = (castka2 - castka) / petitisicovka;

            castka2 = castka;

            castka = castka2 % dvoutisicovka;

            b = (castka2 - castka) / dvoutisicovka;

            castka2 = castka;

            castka = castka2 % tisicovka;

            c = (castka2 - castka) / tisicovka;

            castka2 = castka;

            castka = castka2 % petistovka;

            d = (castka2 - castka) / petistovka;

            castka2 = castka;

            castka = castka2 % dvoustovka;

            e = (castka2 - castka) / dvoustovka;

            castka2 = castka;

            castka = castka2 % stovka;

            f = (castka2 - castka) / stovka;

            castka2 = castka;



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
