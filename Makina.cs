using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotors
{
    public class Makina
    {
        public string Marka;
        public string Modeli;
        public int Viti;
        public string Struktura;
        public string Konsumi;
        public double Motorri;
        public double Kapaciteti;
        public double KapacitetiTotal;
        public double Harxhimi;


        
        public Makina(string marka, string modeli, int viti, string konsumi, string struktura, double motorri, double kapaciteti, double kapacitetiTotal, double harxhimi)
        {
            Marka = marka;
            Modeli = modeli;
            Viti = viti;
            Struktura = struktura;
            Konsumi = konsumi;
            Motorri = motorri;
            Kapaciteti = kapaciteti;
            KapacitetiTotal = kapacitetiTotal;
            Harxhimi = harxhimi;
        }


        public void Xhiro(Makina makina)
        {
            Random rnd = new Random();
            int km = rnd.Next(1, 200);

            double l = km * makina.Harxhimi;

            if (makina.Kapaciteti > l)
            {
                Console.WriteLine("Ti bere nje xhiro!");
                makina.Kapaciteti -= l;
                double cmimi = Cmimi(makina.Konsumi) * l;

                Console.WriteLine($"Ke bere {km} kilometra dhe jane kosumuar {Math.Round(l, 2)} litra {makina.Konsumi}!");
                Console.WriteLine($"Per kete udhetim jane shpenzuar {Math.Round(cmimi, 2)} LEK");
                Console.WriteLine($"Kane mbetur {Math.Round(makina.Kapaciteti, 2)} litra");
            }
            else
            {
                Console.WriteLine("Mbushe!");
            }
        }
        public int Laje(string struktura)
        {
            int cmimi = 0;
            if (struktura == "Sedan")
            {
                cmimi = 600;
            }
            else if (struktura == "Hatchback")
            {
                cmimi = 500;
            }

            Console.WriteLine($"struktura: {struktura}");
            Console.WriteLine($"Ti sapo lave makinen: {cmimi} Lek");

            return cmimi;

        }
        public void Parko()
        {
            int cmimi = 0;
            if (Struktura == "Sedan")
            {
                cmimi = 200;
            }
            else if (Struktura == "Hatchback")
            {
                cmimi = 100;
            }
            Console.WriteLine($"Ti parkove: {Struktura}");
            Console.WriteLine($"Ti sapo parkove makinen: {cmimi} Lek");

        }
        public void Furnizo(Makina makina)
        {
            Console.WriteLine("Sa LEK do ta furnizoni mjetin tuaj?");
            double lek = Convert.ToInt32(Console.ReadLine());

            double l = lek / Cmimi(makina.Konsumi);


            if (makina.Kapaciteti < makina.KapacitetiTotal)
            {
                makina.Kapaciteti += l;

                if (makina.Kapaciteti > makina.KapacitetiTotal)
                {
                    double kusuri = (makina.Kapaciteti - makina.KapacitetiTotal) * Cmimi(makina.Konsumi);


                    makina.Kapaciteti = makina.KapacitetiTotal;

                    double km = makina.Kapaciteti / makina.Harxhimi;
                    double furnizimi = (lek - kusuri) / Cmimi(makina.Konsumi);

                    Console.WriteLine("Ti furnizove makinen!");
                    Console.WriteLine($"Kapaciteti u tejkalua me {Math.Round(furnizimi, 2)} litra {makina.Konsumi}!");
                    Console.WriteLine($"Kusuri: {Math.Round(kusuri, 2)} ALL!");
                    Console.WriteLine($"{Math.Round(makina.Kapaciteti, 2)} litra te mbetura");
                    Console.WriteLine($"{Math.Round(km)} kilometra te mbetura!");
                }
                else
                {
                    double km = makina.Kapaciteti / makina.Harxhimi;

                    Console.WriteLine("Ti furnizove makinen!");
                    Console.WriteLine($"U shtuan {Math.Round(l, 2)} litra {makina.Konsumi}!");
                    Console.WriteLine($"{Math.Round(makina.Kapaciteti, 2)} litra te mbetura");
                    Console.WriteLine($"{Math.Round(km)} kilometra te mbetura!");
                }

            }
            else
            {
                Console.WriteLine("Makina eshte e furnizuar!");
            }

        }

        public void Veprimet()
        {
            Console.WriteLine("1. Bej Xhiro     2. Laj Makinen      3. Parko        4. Furnizo          0. Dil");
        }

        public void ShfaqTeDhenat(Makina makina)
        {
            Console.WriteLine($"Ju zgjodhet {makina.Marka} {makina.Modeli}. Parametrat e makines jane keto:");
            Console.WriteLine($"Viti i Prodhimit: {makina.Viti}");
            Console.WriteLine($"Lloji i Karburantit: {makina.Konsumi}");
            Console.WriteLine($"Motorri: {makina.Motorri}");
        }

        private int Cmimi(string karburanti)
        {
            int cmimi = karburanti == "Nafte" ? 176 : 179;
            return cmimi;
        }
    }

}
// pass by value kalon vetem vleren tek metoda
// pass by  reference kalon te gjith objektin
// ternaty opertors: 