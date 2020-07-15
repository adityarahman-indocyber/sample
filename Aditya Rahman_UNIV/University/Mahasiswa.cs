using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Mahasiswa
    {
        public string NIK { get; set; }
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public DateTime TglLahir { get; set; }
        public string TempatLahir { get; set; }
        public string gender { get; set; }
        public long NoKTP { get; set; }

        public GolonganDarah goldar { get; set; }
        public Agama Religion { get; set; }


        public DateTime tglMasukUniv { get; set; }


        public List<MataKuliah> MataKuliah;
        public List<MataKuliah> getMataKuliah()
        {
            return this.MataKuliah;
        }
        public void setMataKuliah(List<MataKuliah> argMataKuliah)
        {
            this.MataKuliah = argMataKuliah;
        }

        public Mahasiswa()
        { }
        
        public Mahasiswa(string NIK, string NamaDepan, string NamaBelakang, DateTime tglLahir, string TempatLahir, string gender, long NoKTP, DateTime tglMasukUniv)
        {
            this.NIK = NIK;
            this.NamaDepan = NamaDepan;
            this.NamaBelakang = NamaBelakang;
            this.TglLahir = tglLahir;
            this.TempatLahir = TempatLahir;
            this.gender = gender;
            this.NoKTP = NoKTP;
            this.tglMasukUniv = tglMasukUniv;
        }

        public void PrintInfoMhs()
        {
            Console.WriteLine("NIK : {0} Nama : {1} {2} ",this.NIK,this.NamaDepan,this.NamaBelakang);
        }
   
        public void PrintInfoMatkulMhs()
        {
            foreach (MataKuliah item in MataKuliah)
            {
                
            if (item.tglLulusMatkul == DateTime.Today)
            {
                int tahun = DateTime.Now.Year - item.tglNgambilMatkul.Year;
                int bulan = DateTime.Now.Month - item.tglNgambilMatkul.Month;
                int hari = DateTime.Now.Day - item.tglNgambilMatkul.Day;
                if (bulan < 0)
                {
                    bulan = bulan + 12;
                }
                if (hari < 0)
                {
                    hari = hari + 30;
                }
                string durasi = string.Format("({0} Tahun,{1} Bulan,{2} Hari)", tahun, bulan, hari);
                Console.WriteLine("{0} IN {1} ,({2} - NA) Belum Selesai,\nDurasi : {3}, Poin : +{4}.", item.NamaMatkul, item.NamaPenjurusan, item.tglNgambilMatkul.ToString("dd MMMM yyyy"), durasi,item.Poin);
            }
            else if (item.tglLulusMatkul != DateTime.Today)
            {
                    int tahun = item.tglLulusMatkul.Year - item.tglNgambilMatkul.Year;
                    int bulan = item.tglLulusMatkul.Month - item.tglNgambilMatkul.Month;
                    int hari = item.tglLulusMatkul.Day - item.tglNgambilMatkul.Day;
                    if (bulan < 0)
                    {
                        bulan = bulan + 12;
                    }
                    if (hari < 0)
                    {
                        hari = hari + 30;
                    }
                    string durasi = string.Format("({0} Tahun,{1} Bulan,{2} Hari)", tahun, bulan, hari);
                    Console.WriteLine("{0} IN {1} ,({2} - {3}) Sudah Selesai \nDurasi : {4}, Poin : +{5}.", item.NamaMatkul, item.NamaPenjurusan, item.tglNgambilMatkul.ToString("dd MMMM yyyy"), item.tglLulusMatkul.ToString("dd MMMM yyyy"), durasi,item.Poin);
            }
                
            }
      
        }
    }
}
