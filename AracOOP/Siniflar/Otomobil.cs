using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP.Siniflar
{
    class Otomobil : Arac
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
        public Otomobil()
        { }
        public Otomobil(aractipleri tip)
        {
            AracTipi = tip;
        }
        public Otomobil(aractipleri tip, string model)
        {
            AracTipi = tip;
            Model = model;
        }
        public Otomobil(aractipleri tip, string model, int yil)
        {
            AracTipi = tip;
            Model = model;
            Yil = yil;
        }
        public Otomobil(aractipleri tip, string model, int yil, string mensei)
        {
            AracTipi = tip;
            Model = model;
            Yil = yil;
            Mensei = mensei;
        }


        public Otomobil(aractipleri aracTipi, string model, int yil, string mensei, int beygirGucu, string Renk, yakitturu yakit)
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
}
