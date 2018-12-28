using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracOOP.Siniflar;
using Sekiller;
namespace AracOOP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            daire d = new daire();

            Otomobil q = new Otomobil();
            Otomobil o = new Otomobil(aractipleri.kara, "Ford", 2010, "Amerika", 1200,"beyaz",yakitturu.Benzin);            
            Console.WriteLine(o.ToString());
            
            o.ToString();
            Ucak u = new Ucak();
            u.AracTipi = aractipleri.Hava;
            u.BeygirGucu = 1000;
            u.MotorSayisi = 2;
            
            
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
