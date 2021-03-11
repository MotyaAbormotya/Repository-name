using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int[] arrayRandom = new int[width];
            int[] tempArray = new int[width];
            Random random = new Random();

            RandomArray();

            Console.ReadKey();
        }

        public static void RandomArray()
        {

            int width = 5;
            int[] arrayRandom = new int[width];
            int[] tempArray = new int[width];
            Random random = new Random();
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = random.Next(1, 100 + 1);
                Console.Write(arrayRandom[i] + " ");
            }

            for (int i = 0; i < arrayRandom.Length; i++)
            {
                tempArray[i] = arrayRandom[i];
            }
            int z = -1;
            int temp = 0;
            arrayRandom = new int[width];
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                temp = random.Next(0, 4 + 1);
                do
                {
                    z++;
                    if (z == arrayRandom.Length)
                    {
                        z = 0;
                    }
                    temp = random.Next(0, 4 + 1);
                }
                while (tempArray[temp] == arrayRandom[z]);
                arrayRandom[i] = tempArray[temp];
            }

            Console.WriteLine();

            for (int i = 0; i < arrayRandom.Length; i++)
            {
                Console.Write(arrayRandom[i] + " ");
            }
        }
    }
}
