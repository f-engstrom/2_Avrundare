using System;

namespace _Avrundare
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double inmatatDecimalTal = 0;
            int antalDecimaler = 0;
            bool inMatatSiffror = false;
            double avrundatTal;
            Console.Write("Hej, vi ska nu avrunda ett valfritt decimaltal!\n" + "Du kommer få talet utskrivet med 3 decimaler, samt ett antal du väljer själv.\n" + "Vilket tal väljer du?:");

            do //loop testar så att siffror matas in för decimaltalet och ber om tal om annat matas in.
            {
                string strInmatatDecimalTal = Console.ReadLine();
                try
                {
                    inmatatDecimalTal = Convert.ToDouble(strInmatatDecimalTal);
                    inMatatSiffror = true;
                }
                catch
                {
                    Console.WriteLine("Enbart siffror tack.\n" + "Skriv ett tal:");

                }
            } while (inMatatSiffror == false);

            inMatatSiffror = false;

            Console.Write("Hur många decimaler vill du ha?:");


            do //Loop som testar så att siffror matas in för antalet decimaler och ber om tal om annat matas in.
            {
                string strAntalDecimaler = Console.ReadLine();
                try
                {
                    antalDecimaler = Convert.ToInt32(strAntalDecimaler);
                    inMatatSiffror = true;
                }
                catch
                {
                    Console.WriteLine("Enbart siffror tack.\n" + "Skriv ett tal:");

                }
            } while (inMatatSiffror == false);


            avrundatTal = Math.Round(inmatatDecimalTal, antalDecimaler, MidpointRounding.ToEven); //rundar av talet med valt antal decimaler och lägger i ny variable.
            Console.WriteLine("Med tre decimaler blir talet: {0:f3}", inmatatDecimalTal); // rundar av talet med konstant antal, 3, decimaler och skriver ut det.
            Console.WriteLine("Med " + antalDecimaler + " decimaler blir talet: " + avrundatTal); // skriver ut resultatet av math.round avrundningen.
            Console.ReadKey();

        }
    }
}
