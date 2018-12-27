using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            otomobil q = new otomobil();
            otomobil o = new otomobil(aractipleri.kara, "Ford", 2010, "Amerika", 1200,"beyaz",yakitturu.Benzin);            
            Console.WriteLine(o.ToString());
            //o.DepoDoldur = 20;
            //o.DepoDoldur = 30;
            //o.calistir();
            //o.calistir();
            o.ToString();
            ucak u = new ucak();
            u.AracTipi = aractipleri.Hava;
            u.BeygirGucu = 1000;
            u.MotorSayisi = 2;
            
            
        }
    }

    class otomobil : arac
    {
        bool calistimi;
        string renk;
        int kapiSayisi;
        int vitesTipi;
        kasatipi kasaTipi;
        int depo;
        int hiz;

        public int DepoDoldur
        {
            set
            {
                int temp = value + depo;
                if ((temp <= 80 && temp >= 0))
                {
                    depo += value;
                    Console.WriteLine($"Depo şu anda {depo} lt oldu. {value} lt yakit alindi");
                }
                else
                {
                    Console.WriteLine("Alinan yakit depo hacminden fazladir");
                }
            }
        }
        public int hiziArtttir()
        {
            if (calistimi == true)
                hiz += 10;
            else
            {
                Console.WriteLine("Araç Çalişmiyor..");
            }
            return hiz;
        }
        public bool calistir()
        {

            if (depo > 0)
            {
                calistimi = true;
                Console.WriteLine("Araç Çalişti");
            }
            else
            {
                Console.WriteLine("Depo boş.. Yakit Aliniz..");
            }
            return calistimi;

        }
        public bool Durdur()
        {
            if (calistimi == true)
            {
                calistimi = false;
                hiz = 0;
            }
            return calistimi;
        }
        public otomobil()
        { }
        public otomobil(aractipleri tip)
        {
            AracTipi = tip;
        }
        public otomobil(aractipleri tip ,string model)
        {
            AracTipi = tip;
            Model = model;
        }
        public otomobil(aractipleri tip, string model,int yil)
        {
            AracTipi = tip;
            Model = model;
            Yil = yil;
        }
        public otomobil(aractipleri tip, string model, int yil,string mensei)
        {
            AracTipi = tip;
            Model = model;
            Yil = yil;
            Mensei = mensei;
        }


        public otomobil(aractipleri aracTipi,string model, int yil, string mensei,int beygirGucu,string Renk , yakitturu yakit)
        {
            AracTipi = aracTipi;
            Model = model;
            Yil = yil;
            Mensei = mensei;
            BeygirGucu = beygirGucu;
            renk = Renk;
            YakitTuru = yakit;
            this.p = "Protected";
        }
        
       
        public void Durum()
        {
            string c = calistimi ? "Çalişiyor" : "Çalişmiyor";
            
            Console.WriteLine($"Arac şu anda {c} ve hizi {hiz} km Depoda {depo} lt yakit var");
            

        }
        public override string ToString()
        {
            string str;
            str = base.ToString();
            str += $"\nRenk :{renk}\nKasa Tipi :{kasaTipi} ";

            return str;

        }
    }
    
    class arac
    {
        aractipleri aracTipi;
        string model;
        int yil;
        string mensei;
        int beygirGucu;
        yakitturu yakitTuru;
        protected string p;
        public int BeygirGucu
        { get
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
        public string Model {
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
        
    }
    class ucak:arac
    {
        ucakTipleri ucaktip;
        private int motorSayisi;

        private int kapasite;

        public int Kapasite
        {
            get { return kapasite; }
            set {
                if(value>0 && value<20000)
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



    }
    enum aractipleri
    {
        kara = 1,
        Deniz = 2,
        Hava = 3

    }
    enum yakitturu
    {
        Benzin = 1,
        Mazot = 2,
        Elektrik = 3,
        Lpg = 4,
        Nukleer = 5,
        Ruzgar = 6,
        Diger = 7

    }
    enum kasatipi
    {
        Sedan = 1,
        HatchBack =2,
        Station=3,
        Cabrio =4,
        Cupe=5
    }
    enum ucakTipleri
    {
        YolcuUçağı =1,
        KargoUçağı=2,
        SavaşUçaği= 3,
        ÖzelUçak =4
    }
}
