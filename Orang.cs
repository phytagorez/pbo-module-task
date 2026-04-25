using System;
using System.Collections.Generic;
using System.Text;

namespace TugasPBO
{
    public abstract class Orang
    {
        private string _nama;
        private int _umur;

        public string Nama
        {
            get { return _nama; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Nama tidak boleh kodong");
                }
                else
                {
                    _nama = value;
                }
            }
        }
        public int Umur
        {
            get { return _umur; }
            set
            {
                if (_umur < 0)
                {
                    Console.WriteLine("Umur tidak boleh kurang dari 0");
                }
            }
        }
        public Orang(string nama, int umur)
        {
            this._nama = nama;
            this._umur = umur;
        }

        public abstract void Aktivitas(); //wajib di ovveride nanti oleh setip subclass

        public virtual void InfoOrang()
        {
            Console.WriteLine($"Spesifikasi seorang subar: {Nama}, {Umur}");
        }

    }
}
