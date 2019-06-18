using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNama = { "aa", "bb", "cc", "dd" };
            Console.WriteLine(arrayNama[2] + "\n");

            for(int i = 0; i < arrayNama.Length; i++)
            {
                Console.WriteLine(arrayNama[i]);
            }
            Console.WriteLine();

            foreach(string nama in arrayNama)
            {
                Console.WriteLine(nama);
            }
            Console.WriteLine();

            int[] arrayBilangan = new int[3];

            arrayBilangan[0] = 1;
            arrayBilangan[1] = 2;
            arrayBilangan[2] = 3;

            foreach(int bil in arrayBilangan)
            {
                Console.WriteLine(bil.ToString());
            }
        }
    }
}
