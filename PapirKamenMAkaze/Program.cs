using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papirKamenMakaze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Igra PAPIR-KAMEN-MAKAZE,svoj potez unosite malim slovima (npr:papir,kamen,makaze)");
            string[] player1 = new string[10];
            string[] player2 = new string[10];
            int p1p = 0;
            int p2p = 0;
            string p = "papir";
            string k = "kamen";
            string m = "makaze";
            Console.WriteLine("Unesi Ime Prvog Igraca: ");
            string Ime1 = Console.ReadLine();
            Console.WriteLine("Unesi Ime Drugog Igraca: ");
            string Ime2 = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (p1p < 5 && p2p < 5)
                {
                    Console.WriteLine("{0} unosi svoj potez: ", Ime1);
                    player1[i] = Console.ReadLine();
                    if (player1[i] != p && player1[i] != k && player1[i] != m)
                    {
                        Console.WriteLine("Nepravilan Unos {0}",Ime1);
                    }
                    Console.WriteLine("{0} unosi svoj potez: ", Ime2);
                    player2[i] = Console.ReadLine();
                    if (player2[i] != p && player2[i] != k && player2[i] != m)
                    {
                        Console.WriteLine("Nepravilan Unos {0}",Ime2);
                    }

                    if (player1[i] == p && player2[i] == k)
                    {
                        p1p += 1;
                    }
                    else if (player1[i] == p && player2[i] == m)
                    {
                        p2p += 1;
                    }
                    else if (player1[i] == k && player2[i] == m)
                    {
                        p1p += 1;
                    }
                    else if (player1[i] == k && player2[i] == p)
                    {
                        p2p += 1;
                    }
                    else if (player1[i] == m && player2[i] == p)
                    {
                        p1p += 1;
                    }
                    else if (player1[i] == m && player2[i] == k)
                    {
                        p2p += 1;
                    }
                    else if (player1[i] != p && player1[i] != k && player1[i] != m)
                    {
                        p2p += 1;
                    }
                    else if (player2[i] != p && player2[i] != k && player2[i] != m)
                    {
                        p1p += 1;
                    }
                    else
                    {
                        Console.WriteLine(" Nema pobednika u ovoj rundi");
                    }
                    Console.WriteLine("Rezulatat je {2}  {0} : {3}  {1}", p1p, p2p, Ime1, Ime2);
                }
            }
            if (p1p > p2p)
            {
                Console.WriteLine("Pobednik je {2} sa rezulatatom {0}:{1}", p1p, p2p, Ime1);
            }
            else if (p2p > p1p)
            {
                Console.WriteLine("Pobednik je {2} sa rezulatatom {0}:{1}", p1p, p2p, Ime2);
            }

        }
    }
}
