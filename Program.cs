using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_system1
{
    class Program
    {
        static int Score = 0;
        static int Health = 100;
        static int Shield = 100;
        static int Lives = 3;
        static int Multiplier = 2;
        static int Damege = 10;
        static bool isAlive = true;

        static void Main(string[] args)
        {
            while (isAlive == true)
            {
                showHUD();
                multiplier();
                damege();
                lives();
            }
            

        }
        static void showHUD()
        {

            Console.WriteLine("score = " + Score);
            Console.WriteLine("health = " + Health);
            Console.WriteLine("shield = " + Shield);
            Console.WriteLine("lives = " + Lives);

            Console.ReadKey();
        }
        static void multiplier()
        {
            Score += 100 * Multiplier;

        }
 
        static void damege()
        {

            if (Shield > 0)
            {
                Shield -= Damege;
            }
            else
            {
                Health -= Damege;
            }

            if (Health == 0)
            {
                Lives -= 1;
                Health = 100;
                Shield = 100;
            }
        
        }
        static void lives()
        {
            if (Score >= 1000)
            {
                Lives += 1;
            }
        }
    }
}
