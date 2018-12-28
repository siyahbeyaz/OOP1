using System;

namespace Sekiller
{
    public  class Sekiller:Isekil
    {
        string sekiltip;

        private double cevre;
        private double alan;
        private double hacim;

        public double Cevre
        {
            get { return cevre; }
            set { cevre = value; }
        }

        public double Alan
        {
            get { return alan; }
            set { alan = value; }
        }

        public double Hacim
        {
            get { return hacim; }
            set { hacim = value; }
        }



        public string SekilTip
        {
            get
            {
                return sekiltip;
            }
            set
            {
                sekiltip = value;
            }
        }

        public Sekiller()
        {
                
        }

        public void Yazdir()
        {
            Console.WriteLine($"Alan: {Alan}\nCevre :{Cevre} \nHacim {Hacim}"); ;
        }
    }
}
