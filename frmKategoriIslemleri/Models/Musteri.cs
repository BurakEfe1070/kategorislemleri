using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmKategoriIslemleri.Models
{
    public class Musteri
    {
        public int Id { get; set; }

        public string ad_soyad { get; set; }

        public string firma_Adi { get; set; }

        public int telefon {  get; set; }
        
        public string mail { get; set; }

        public string adres { get; set; }

        public virtual ICollection<Satis> Satislar { get; set; }=new HashSet<Satis>();
    }
}
