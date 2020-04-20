using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KonsoliKikkailuHarjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toprint = new List<string>();
            int x = 0;
            int y = 0;
            int z = 0;

            //Console.WriteLine("Kirjoita tekstiä: ");
            //toprint.Add(Console.ReadLine());

            void Kirjoitus(List<string> toprint, int X, int Y, int Z)
            {
                Console.WriteLine("Kirjoita printattava teksti:");          //määritellään teksti
                toprint.Add(Console.ReadLine());

                Console.WriteLine("Anna tekstin positio x akselilla:");     //määritellään positio x akselilla
                X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Anna tekstin positio y akselilla:");     //määritellään positio y akselilla
                Y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Anna kirjoitus nopeus:");                //määritellään kirjoitus nopeus
                Z = Convert.ToInt32(Console.ReadLine());

                Console.SetCursorPosition(X, Y);

                
                for (int c = 0; c < 5; c++)
                {
                    string text = toprint[0];
                    foreach (char character in text)                        //ottaa yhden characterin text(string), joka on toprint[0]
                    {
                        for (int i = 0; i < toprint.Count; i++)             //kirjoittaa yhden kirjaimen
                        {
                            //string text = Convert.ToString(toprint[0]);
                            Console.Write($"{character}");
                            System.Threading.Thread.Sleep(Z);
                            //Task.Delay(Z);
                        }
                    }
                    Y += 1;
                    Console.SetCursorPosition(X, Y);
                }

                Console.ReadLine();
            }

            Kirjoitus(toprint, x, y, z);

        }
    }
}
