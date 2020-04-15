using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2645
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawana pertama = new Karyawana(1,"19030008","paijo",3000000);
            Karyawana kedua = new Karyawana(2, "19030009", "paijan", 2000000);
            TampilkanGaji(pertama);
            TampilkanGaji(kedua);
            Console.WriteLine("No Nik/Nama\t Gaji Bulanan");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Mantap Kenaikan gaji 10%");
            Console.WriteLine("No Nik/Nama\t Gaji Bulanan");
            Console.WriteLine("-------------------------------");
            TambahanGaji(pertama);
            TambahanGaji(kedua);

            Console.ReadKey();
            
        }
        static void TampilkanGaji(Karyawana Pegawai)
        {
            Console.WriteLine(Pegawai._nomer + ". " + Pegawai._nik + " " + Pegawai._nama + " " + Pegawai._gaji);
        }

        static void TambahanGaji(Karyawana Pegawai)
        {
            double tambahan;
            tambahan = Pegawai._gaji * 0.1;
            Pegawai._gaji = Pegawai._gaji + tambahan;
            Console.WriteLine(Pegawai._nomer + ". " + Pegawai._nik + " " + Pegawai._nama + " " + Pegawai._gaji);
        }

       
    }
}
