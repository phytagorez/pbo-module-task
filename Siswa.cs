using System;
using System.Collections.Generic;
using System.Text;
using TugasPBO;

namespace TugasPBO
{
    public class Siswa : Orang
    {
        private string _kelas;
        public string Kelas
        {
            get { return _kelas; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Kelas tidak boleh kosong");
                }
                else
                {
                    _kelas = value;
                }
            }
        }

        public Siswa(string nama, int umur, string kelas) : base(nama, umur)
        {
            this._kelas = kelas;
        }

        public void Belajar()
        {
            Console.WriteLine($"{Nama} sedang belajar");
        }

        public override void Aktivitas() //wajib override
        {
            Console.WriteLine($"pada umur {Umur} tahun {Nama} niat banget buat pergi kelas {Kelas}");
        }

        public override void InfoOrang()
        {
            Console.WriteLine($"Nama: {Nama}, Umur: {Umur}, Kelas: {Kelas}");
        }
    }

    public class SiswaSD : Siswa
    {
        public SiswaSD(string nama, int umur, string kelas) : base(nama, umur, kelas) { }

        public void Main()
        {
            Console.WriteLine($"{Nama} dari SDN 1 Banyuwangi tawuran dengan mas tunggul");
        }

        public void UjianNasional()
        {
            Console.WriteLine($"{Nama} sudah insaf tawuran dan mengikuti ujian nasional agar lulis sd");
        }

        public override void Aktivitas() //wajib override
        {
            Console.WriteLine($"{Nama} sedang main gobak sodar saat jam istirahat berlangsung");
        }
    }

    public class SiswaSMA : Siswa
    {
        public SiswaSMA (string nama, int umur, string kelas) : base(nama, umur, kelas) { }

        public void Main()
        {
            Console.WriteLine($"{Nama} dari stm kalibaru vs mas tunggul sma 1 glenmore");
        }

        public void UjianNasional()
        {
            Console.WriteLine($"{Nama} melakukan formalitas ujian dikarenakan dia dari stm");
        }

        public override void Aktivitas() //wajib override
        {
            Console.WriteLine($"{Nama} pada {Umur} melakukan pkl");
        }
    }

}
