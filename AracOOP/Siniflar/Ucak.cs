using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP.Siniflar
{
    class Ucak : Arac,  IKapasite
    {
        ucakTipleri ucaktip;
        private int motorSayisi;

        private int kapasite;

        public int Kapasite
        {
            get { return kapasite; }
            set
            {
                if (value > 0 && value < 20000)
                    kapasite = value;
                else
                {
                    Console.WriteLine("Kapasite 0           ila 20000 kg arasi olmalidir");
                }
            }
        }

        public int MotorSayisi
        {
            get { return motorSayisi; }
            set { motorSayisi = value; }
        }
        private int yolcuSayisi;

        public int YolcuSayisi
        {
            get { return yolcuSayisi; }
            set { yolcuSayisi = value; }
        }
        public ucakTipleri UcakTipi
        {
            get
            {
                return ucaktip;
            }
            set
            {
                ucaktip = value;
            }
        }
        public void KapasiteYaz()
        {
            Console.WriteLine($"Yolcu Sayisi:{YolcuSayisi}\nMotorSayisi :{MotorSayisi}\nKapasite:{Kapasite}");
        }
    }
}
