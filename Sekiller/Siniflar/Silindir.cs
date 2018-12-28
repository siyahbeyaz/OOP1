using System;

namespace Sekiller
{
    class Silindir:daire
    {
        private double yukseklik;

        public double Yukseklik
        {
            get { return yukseklik; }
            set { yukseklik = value; }
        }

        public Silindir(int r,double h):base(r)
        {
            Yukseklik = h;
            Hacim = base.Alan * Yukseklik;
            Alan = 2 * base.Alan + Yukseklik * base.Cevre;
           
        }


    }
}
