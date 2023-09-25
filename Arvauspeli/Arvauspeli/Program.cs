using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvauspeli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arvaukset = new List<int>();
            Random rand = new Random();
            int arvattavaLuku = rand.Next(1, 101);
            int arvaus = 0;
            string strArvaus = "";

            Console.WriteLine("Tervetuloa arvauspeliin. Arvaa luku väliltä 1-100.");

            while (true)
            {
                Console.Write("Anna arvauksesi: ");
                strArvaus = Console.ReadLine();
                try 
                {
                    arvaus = int.Parse(strArvaus);
                    
                    if (arvaus < 1 || arvaus > 100) 
                    {
                        Console.WriteLine("Syötä luku väliltä 1-100");
                        continue;
                    }
                
                    arvaukset.Add(arvaus);

                    if (arvaus > arvattavaLuku)
                    {
                        Console.WriteLine("Luku on pienempi kuin arvaus.");
                    }
                    else if (arvaus < arvattavaLuku)
                    {
                        Console.WriteLine("Luku on suurempi kuin arvaus.");
                    }
                    else
                    {
                        Console.WriteLine("Onneksi olkoon! Arvasit oikein!");
                        Console.WriteLine("Tarvitsit " + arvaukset.Count + " arvausta.");
                        Console.WriteLine("Arvauksesi olivat:");

                        for (int i = 0; i < arvaukset.Count; i++)
                        {
                            Console.WriteLine("Arvaus " + (i + 1) + ": " + arvaukset[i]);
                        }

                        break;
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Syötä kokonaisluku.");
                }
            }

            Console.ReadLine();

        }
    }
}
