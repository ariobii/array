using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nama = "Aulia";
            mhs1.Nilai = 90;
            mhs1.Nim = "2279";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nama = "Bimo ";
            mhs2.Nilai = 95;
            mhs2.Nim = "2277";

            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.Nama = "Ario ";
            mhs3.Nilai = 85;
            mhs3.Nim = "2278";

            Mahasiswa[] arrayMhs = new Mahasiswa[3];
            arrayMhs[0] = mhs1;
            arrayMhs[1] = mhs2;
            arrayMhs[2] = mhs3;

            Console.WriteLine("No. NIM    Nama    Nilai");
            Console.WriteLine("--------------------------");
            
            //Pakai for
            /*
            for(int i=0; i < arrayMhs.Length; i++)
            {
                Console.WriteLine("{0}   {1}    {2}     {3}", i + 1, arrayMhs[i].Nim, arrayMhs[i].Nama, arrayMhs[i].Nilai);
            }
            */

            //Pakai foreach
            int j=1;
            foreach(Mahasiswa mhs in arrayMhs)
            {
                Console.WriteLine("{0}   {1}   {2}   {3}", j, mhs.Nim, mhs.Nama, mhs.Nilai);
                j++;
            }
        }
    }
}
