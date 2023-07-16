using AutoMotors;

var leketNeGjendje = 400;

Makina audi = new Makina("Audi", "A7", 2014, "Nafte", "Sedan", 3.0, 75, 75, 0.047);
Makina bmw = new Makina("BMV"," M4 Competition",2008,"Sedan", "Benzine", 3.6, 57, 57, 0.098);
Makina mercedes = new Makina("Mercedes-Benz","W204",2012,"Sedan","Benzine",6.3,66,66,0.134);


Console.WriteLine("Mire se vini ne AUTO Motors");
Console.WriteLine("Ju lutem zgjidhni nje makine:");

Console.WriteLine($"1. {audi.Marka} {audi.Modeli}           2. {bmw.Marka} {bmw.Modeli}         3.{mercedes.Marka} {mercedes.Modeli}");
int opsioni = Convert.ToInt32(Console.ReadLine());

if (opsioni == 1)
{
    audi.ShfaqTeDhenat(audi);
    while (true)
    {
        audi.Veprimet();
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
            audi.Xhiro(audi);
        }
        else if (op == 2)
        {
            audi.Laje(audi.Struktura);
        }
        else if (op == 3)
        {
            audi.Parko();
        }
        else if (op == 4)
        {
            audi.Furnizo(audi);
        }
        else if (op == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Zgjedhje eshte e gabuar!");
        }
    }

}
//else if (opsioni == 2)
//{
bmw.ShfaqTeDhenat(bmw);

//    while (true)
//    {
//        Console.WriteLine("1. Bej Xhiro     2. Laj Makinen      3. Parko        4. Furnizo          0. Dil");
//        int op = Convert.ToInt32(Console.ReadLine());

//        if (op == 1)
//        {
//            Random rnd = new Random();
//            int km = rnd.Next(1, 200);

//            bmw.Xhiro();

//            // BMW harxhon 9.6l - 100 km => 0.096l - 1km
//            // Cmimi aktual i benzines = 179 LEK / l

//            double l = km * 0.096;


//            if (bmw.Kapaciteti > l)
//            {
//                bmw.Kapaciteti -= l;

//                double cmimi = 179 * l;

//                audi.Xhiro();
//                Console.WriteLine($"Ke bere {km} kilometra dhe jane kosumuar {l} litra nafte!");
//                Console.WriteLine($"Per kete udhetim jane shpenzuar {Math.Round(cmimi, 2)} LEK");
//                Console.WriteLine($"Kane mbetur {Math.Round(bmw.Kapaciteti, 2)} litra");
//            }
//            else
//            {
//                Console.WriteLine("Mbushe!");
//            }
//            continue;
//        }
//        else if (op == 2)
//        {
//            bmw.Laje();
//            continue;
//        }
//        else if (op == 3)
//        {
//            bmw.Parko();
//            continue;
//        }
//        else if (op == 4)
//        {
//            Console.WriteLine("Sa LEK do ta furnizoni mjetin tuaj?");
//            double lek = Convert.ToInt32(Console.ReadLine());

//            // Cmimi aktual i benzines = 179 LEK / l

//            double l = lek / 176;

//            if (l < audi.Kapaciteti)
//            {
//                bmw.Kapaciteti += l;
//                double km = l / 0.096;


//                bmw.Furnizo();
//                Console.WriteLine($"U shtuan {l} litra benzine!");
//                Console.WriteLine($"{km} te mbetura!");
//            }
//            else
//            {
//                Console.WriteLine("Makina eshte e furnizuar!");
//            }


//            continue;
//        }
//        else if (op == 0)
//        {
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Zgjedhje eshte e gabuar!");
//            continue;
//        }
//    }
//}