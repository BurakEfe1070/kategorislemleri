 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace frmKategoriIslemleri.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        public string ad { get; set; }

        public string soyad { get; set; }

        public string telefon { get; set; }

        public string mail { get; set; }

        public string adres { get; set; }

        public string kullanici_adi { get; set; }

        public string sifre { get; set; }




        [ForeignKey("Yetki")]

        public virtual Yetki Yetki { get; set; }

        public virtual ICollection<Satis> Satislar { get; set; } = new HashSet<Satis>();
    }
}
