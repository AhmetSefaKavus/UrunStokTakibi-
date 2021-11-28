using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace urunStokTakibi.Models
{
    public class urunVeri
    {

        public static List<urun> urunler = new List<urun>()
        {
            new urun()
            {
                Id=183553,
                Ad="Gecem 7W Led Ampul E27 Duylu",
                urunRengi="Gün Işığı",
                ListeFiyatı=15,
                stokAdeti=1550
            },
            new urun()
            {
                Id= 90110400,
                Ad="Multi-let Dörtlü Priz UPS Topraklı Klemensli",
                urunRengi="Beyaz",
                ListeFiyatı=67,
                stokAdeti=93
            },
            new urun()
            {
                Id=90303300,
                Ad="Topraklı Üçlü Fiş-Priz Yonca",
                urunRengi="Siyah",
                ListeFiyatı=35,
                stokAdeti=158
            },
            new urun()
            {
                Id=90303300,
                Ad="Topraklı Üçlü Fiş-Priz Yonca",
                urunRengi="Siyah",
                ListeFiyatı=35,
                stokAdeti=158
            },
            new urun()
            {
                Id=92190811,
                Ad="Trenda Tekli Çerçeve",
                urunRengi="Dore Metal",
                ListeFiyatı=74,
                stokAdeti=53
            },
            new urun()
            {
                Id=92605314,
                Ad="Novella-Trenda Işıklı Light Kapak",
                urunRengi="Antrasit",
                ListeFiyatı=10,
                stokAdeti=746
            },
        };

    }
}
