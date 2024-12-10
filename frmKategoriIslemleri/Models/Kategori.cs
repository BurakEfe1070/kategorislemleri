using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmKategoriIslemleri.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public virtual ICollection<Urun> Urunler { get; set; }=new HashSet<Urun>();
    }
}
 