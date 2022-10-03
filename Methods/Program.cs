using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
          static int score;
        static int Health;
        static void Main(string[] args)
        {
            Console.WriteLine("Methods");

            score = 0;
            int EnemyValue;
            int EnemyDMG;
            EnemyValue = 200;
            Health = 100;
            EnemyDMG = -50;


            ShowHUD();
            score = score + EnemyValue;
            Health = Health + EnemyDMG;
            ShowHUD();
            

            Console.ReadKey(true);

        }

        


        static void ShowHUD()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("----------------");
            Console.WriteLine();
        }
    } 
}
