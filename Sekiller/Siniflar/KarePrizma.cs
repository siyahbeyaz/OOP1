using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class KarePrizma:kare
    {
        private int yukseklik;

        public int Yukseklik
        {
            get { return yukseklik; }
            set { yukseklik = value; }
        }

        public KarePrizma()
        { }

        public KarePrizma(int h,int kenar):base(kenar)
        {
            Yukseklik = h;
            Hacim = Yukseklik * base.Alan;
            Alan = (Yukseklik * base.Cevre) + (base.Alan * 2);
        }

    }
}
