using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class MataKuliah
    {
        public string NamaMatkul { get; set; }
        public string NamaPenjurusan { get; set; }
        public int Poin { get; set; }

        public DateTime tglNgambilMatkul { get; set; }
        public DateTime tglLulusMatkul { get; set; }

        public MataKuliah()
        {

        }

        public MataKuliah(string NamaMatkul, string NamaPenjurusan)
        {
            this.NamaMatkul = NamaMatkul;
            this.NamaPenjurusan = NamaPenjurusan;   
        }

        public MataKuliah(string NamaMatkul, string NamaPenjurusan, int Poin, DateTime tglNgambilMatkul, DateTime tglLulusMatkul)
        {
            this.NamaMatkul = NamaMatkul;
            this.NamaPenjurusan = NamaPenjurusan;
            this.Poin = Poin;
            this.tglNgambilMatkul = tglNgambilMatkul;
            this.tglLulusMatkul = tglLulusMatkul;
        }


    }
}
