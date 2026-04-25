using System;
using System.Collections.Generic;
using System.Text;
using TugasPBO;

namespace TugasPBO
{
    public class Guru : Orang
    {
        private string _mataPelajaran;

        public string MataPelajaran
        { 
            get { return _mataPelajaran; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Mapel tidak boleh kosong kink");
                }
                else
                {
                    _mataPelajaran = value;
                }
            }
        }

        public Guru(string nama, int umur, string mapel) : base(nama, umur)
        {
            this._mataPelajaran = mapel;
        }

        public void Mengajar()
        {
            Console.WriteLine($"{Nama} mengajar mapel {MataPelajaran}");
        }

        public override void Aktivitas() //wajib override
        {
            Console.WriteLine($"{Nama} pada umur {Umur} tahun akan melakukan kongres pemuda bersama mas rejak ti 25 setlah parktikum {MataPelajaran}");
        }

        public override void InfoOrang()
        {
            Console.WriteLine($"Nama: {Nama}, Umur: {Umur}, Mapel: {MataPelajaran}");
        }
    }
    public class GuruMatematika : Guru
    {
        public GuruMatematika(string nama, int umur) : base(nama, umur, "Matematika") { }

        public void MengajarHitung() // method khusus GuruMatematika
        {
            Console.WriteLine($"{Nama} sedang mengajarkan cara menghitung aljabar.");
        }

        public override void Aktivitas()  // wajib override
        {
            Console.WriteLine($"{Nama} sedang membuat soal ujian Matematika.");
        }
    }

    public class GuruBahasa : Guru
    {
        public GuruBahasa(string nama, int umur) : base(nama, umur, "Bahasa") { }

        public void MengajarBahasa() // method khusus GuruBahasa
        {
            Console.WriteLine($"{Nama} sedang mengajarkan bahasa turki kepada subar");
        }

        public override void Aktivitas()  // wajib override
        {
            Console.WriteLine($"{Nama} sedang marah kepada subar!!");
        }
    }
}
