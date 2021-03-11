using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] healthBar = new int[10];
            int health = 0;
            Random random = new Random();
            Console.Write('[');
            for (int i = 0; i < healthBar.Length; i++)
            {
                healthBar[i] = random.Next(0, 1 + 1);
                if (healthBar[i] == 1)
                    health++;
            }
            for (int i = 0; i < health; i++)
            {
                Console.Write('%');
               
            }
            for (int i = 0; i < healthBar.Length; i++)
            {
                if(healthBar[i] == 0)
                Console.Write('_');
            }
            Console.Write(']');
            Console.WriteLine();
            for (int i = 0; i < healthBar.Length; i++)
            {
                Console.Write(healthBar[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
