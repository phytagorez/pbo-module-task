using System;
using System.Collections.Generic;
using TugasPBO;


namespace Running
{
    public class Program
    {
        public static void Main()
        {
            Sekolah UNEJ = new Sekolah();

            Guru guruUmum = new Guru("Subar", 20, "Komputer Jaringan");
            Siswa siswaWibu = new Siswa("David", 21, "Pemorgraman Berorientasi Objek");
            GuruMatematika cikguMath = new GuruMatematika("Bu Nova", 30);
            SiswaSMA siswaSTM = new SiswaSMA("Ejak", 19, "TKJ");
            GuruBahasa pakTumpul = new GuruBahasa("Tumpul", 22);

            //praktik no1
            Console.WriteLine("No 1");
            guruUmum.Aktivitas();
            siswaWibu.Aktivitas();

            Console.WriteLine();

            //praktik no2
            Console.WriteLine("No 2");
            cikguMath.MengajarHitung();

            Console.WriteLine();

            //praktik no3
            Console.WriteLine("No 3");
            cikguMath.InfoOrang();

            Console.WriteLine();

            //praktik no4
            Console.WriteLine("No 4");
            siswaSTM.UjianNasional();

            Console.WriteLine();

            //praktik no5
            Console.WriteLine("No 5");
            Orang bocilSD = new SiswaSD("Bocil", 10, "4 SD");
            bocilSD.Aktivitas();

            //praktik no6
            Console.WriteLine();
            Console.WriteLine("No 6");
            Console.WriteLine("Daftar orang2 unej tepatnya di di ilkom\n");

            UNEJ.TambahOrang(guruUmum);
            UNEJ.TambahOrang(siswaWibu);
            UNEJ.TambahOrang(cikguMath);
            UNEJ.TambahOrang(siswaSTM);
            UNEJ.TambahOrang(pakTumpul);
            UNEJ.TambahOrang(bocilSD);

            Console.WriteLine();
            UNEJ.DaftarOrang();

        }
    }
}
