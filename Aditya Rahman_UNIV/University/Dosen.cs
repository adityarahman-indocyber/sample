using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Dosen
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

        public decimal gaji { get; set; }
        public DateTime tglMasukKerja { get; set; }


        public List<MataKuliah> MataKuliah;
        public List<MataKuliah> getMataKuliah()
        {
            return this.MataKuliah;
        }
        public void setMataKuliah(List<MataKuliah> argMataKuliah)
        {
            this.MataKuliah = argMataKuliah;
        }

        public Dosen(string NIK, string NamaDepan, string NamaBelakang, DateTime tglLahir, string TempatLahir, string gender, long NoKTP, DateTime tglMasukKerja, decimal gaji)
        {
            this.NIK = NIK;
            this.NamaDepan = NamaDepan;
            this.NamaBelakang = NamaBelakang;
            this.TglLahir = tglLahir;
            this.TempatLahir = TempatLahir;
            this.gender = gender;
            this.NoKTP = NoKTP;

            this.tglMasukKerja = tglMasukKerja;
            this.gaji = gaji;
      
        }
        public void PrintInfoDosen()
        {
            Console.WriteLine("NIK Dosen : {0} , Nama Lengkap : {1} {2} ",this.NIK,this.NamaDepan,this.NamaBelakang);
        }

        public void PrintInfoMatkulDosen()
        {
            foreach (MataKuliah item in MataKuliah)
            {
                Console.WriteLine("{0} in {1} ",item.NamaMatkul, item.NamaPenjurusan);
            }

        }
    }
}
