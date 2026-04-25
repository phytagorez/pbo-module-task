using System;
using System.Collections.Generic;
using TugasPBO;

namespace TugasPBO
{
    public class Sekolah
    {
        private List<Orang> _koleksiOrang;

        public List<Orang> KoleksiOrang
        {
            get { return _koleksiOrang; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Koleksi data orang tidak boleh null!");
                }
                else
                {
                    _koleksiOrang = value;
                }
            }
        }

        public Sekolah()
        {
            this._koleksiOrang = new List<Orang>();
        }

        public void TambahOrang(Orang orang)
        {
            KoleksiOrang.Add(orang);
            Console.WriteLine($"{orang.Nama} berhasil ditambahkan ke daftar");
        }

        public void DaftarOrang()
        {
            if (KoleksiOrang.Count == 0)
            {
                Console.WriteLine("belum ada data orang");
                return;
            }

            foreach (Orang o in KoleksiOrang)
            {
                o.InfoOrang();
            }
            Console.WriteLine();
        }
    }
}