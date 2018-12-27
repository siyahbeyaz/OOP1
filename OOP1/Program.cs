using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tarihBilgisi t = new tarihBilgisi();
            //t.ekranaBas();
            //t.SetTarih=DateTime.Now.AddDays(-25).ToString();
            //t.ekranaBas();
            //Console.WriteLine(t.GunFarki(DateTime.Now.ToString()));


            Maymun Charlie = new Maymun();
            Charlie.el = 2;
            Charlie.ayak = 2;
            Charlie.goz = 2;
            Charlie.tur = (int)CanliTip.Hayvan;
            Charlie.Konus();
            
        }
    }

    public class tarihBilgisi
    {
        private DateTime _trh;

        public String SetTarih
        {
            set { _trh = Convert.ToDateTime(value); }
        }

        private double GunFarki(DateTime farkAlinacaktarih)
        {
            return (farkAlinacaktarih - _trh).TotalDays;
        }

        public string GunFarki(string Yenitarih)
        {
            return GunFarki(Convert.ToDateTime(Yenitarih)).ToString() + " gün fark var";
        }
        public void ekranaBas()
        {
            Console.WriteLine(_trh.ToString());

        }
    }

    public class Canli
    {


        public int el;
        public int ayak;
        public int tur;
        public int goz;


        public Canli(int el, int ayak, int tur, int goz)
        {
            this.el = el;
            this.ayak = ayak;
            this.tur = tur;
            this.goz = goz;
        }

        public Canli()
        {

        }

       

    }

    enum CanliTip
    {
        Insan = 0,
        Hayvan = 1
    }

    public class Maymun : Canli
    {
        public void Konus()
        {
            Console.WriteLine("Muuuuzzz");
            Console.WriteLine(el);
            Console.WriteLine(ayak);
            Console.WriteLine(goz);
            Console.WriteLine(tur);



        }

    }
    public class Kopek : Canli
    {
        public void Konus()
        {
            Console.WriteLine("Kemiiiiikkk");
            Console.WriteLine(el);
            Console.WriteLine(ayak);
            Console.WriteLine(goz);
            Console.WriteLine(tur);



        }
    }

    public class Inek : Canli
    {

    }


}
