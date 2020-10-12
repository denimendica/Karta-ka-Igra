using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaskaIgra
{
    class Program
    {
        static void Main(string[] args)
        {
            int karta1;
            int zbrojBodova=0;

           

            for(int i=0; i=3; i++)
            {
                Console.WriteLine("Upišite vrijednost karte od 1 do 13.");
                Console.Write(karta1);

                if (karta1 < 1 || karta1 > 13)
                {
                    Console.WriteLine("NETOČNO");
                    continue;
                }
                else
                {
                    zbrojBodova += karta1;
                }

                if (zbrojBodova == 31)
                {
                    Console.WriteLine("Pobijedili ste!");

                }
                else
                {
                    Console.WriteLine("Izgubili ste");
                }

                

            }

            Console.ReadLine();

        }
    }
}
