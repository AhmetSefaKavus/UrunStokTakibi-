using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace urunStokTakibi.Models
{
    public class urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string urunRengi { get; set; }
        public int ListeFiyatı { get; set; }
        public int stokAdeti { get; set; }

    }
}
