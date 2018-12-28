using AracOOP.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP
{
    class Arac : IArac
    {
        aractipleri aracTipi;
        string model;
        int yil;
        string mensei;
        int beygirGucu;
        yakitturu yakitTuru;
        protected string p;
        public int BeygirGucu
        {
            get
            {
                return beygirGucu;
            }
            set
            {
                if (value > 0 && value <= 1000)
                    beygirGucu = value;
                else
                {
                    Console.WriteLine("Beygir gücü 0 ila 1000 arasinda olmalidir");
                }
            }
        }
        public string Mensei
        {
            get
            {
                return mensei;
            }

            set
            {
                mensei = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public yakitturu YakitTuru
        {
            get
            {
                return yakitTuru;
            }
            set
            {
                yakitTuru = value;
            }
        }
        public int Yil
        {
            get
            {
                return yil;
            }
            set
            {
                if (value >= 1908 && value <= DateTime.Now.Year)
                {
                    yil = value;
                }
                else
                {
                    Console.WriteLine($"Arac üretim yili 1908 yilindan küçük ve bulunduğun yildan büyük olmamaz");
                }
            }
        }
        public aractipleri AracTipi
        {
            get
            {
                return aracTipi;
            }
            set
            {
                aracTipi = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Temel Özellikler");
            sb.AppendLine("-----------------");
            sb.AppendLine($"Arac Modeli :{Model}");
            sb.AppendLine($"Arac Yili :{Yil} ");
            sb.AppendLine($"Mensei :{Mensei} ");
            sb.AppendLine($"Arac Tipi: {AracTipi}");
            sb.AppendLine($"Beygir Gucu : {BeygirGucu}");
            sb.AppendLine($"Yakit Tipi {YakitTuru}");
            sb.AppendLine("--------------------");

            return sb.ToString();
        }

        public void Yaz()
        {

            Console.WriteLine(this.ToString());
        }
    }
}
