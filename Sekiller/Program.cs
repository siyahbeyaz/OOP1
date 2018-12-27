using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    class Program
    {
        static void Main(string[] args)
        {
            kare k = new kare(5);
            Console.WriteLine($"Karenin Cevresi: {k.Cevre}  Alani : {k.Alan}");

            dikdortgen d = new dikdortgen(6, 8);
            Console.WriteLine($"Dikdörtgenin Cevresi: {d.Cevre}  Alani : {d.Alan}");

            daire da = new daire(5);
            Console.WriteLine($"Dikdörtgenin Cevresi: {da.Cevre}  Alani : {da.Alan}");

            KarePrizma prizma = new KarePrizma(5, 5);
            Console.WriteLine($"Prizma Alani: {prizma.Alan}  Hacmi : {prizma.Hacim}");
            Console.ReadLine();

            

        }

    }
    public class sekiller
    {
        string sekiltip;

        internal double cevre;
        internal double alan;
        internal double hacim;

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


    }
    /// <summary>
    /// Kare Sinifi ve metodlari 
    /// </summary>
    public class kare : sekiller
    {
        int kenarUzunlugu;
        public int KenarUzunlugu
        {
            get
            {
                return kenarUzunlugu;
            }
            set
            {
                if (value > 0)
                    kenarUzunlugu = value;
                else
                    Console.WriteLine("Kenar Uzunluğu  0 dan büyük olmalidir");
            }
        }
        
        /// <summary>
        /// Bu Kare sinifidir. Kenar uzunluğu alir.
        /// </summary>
        /// <param name="kenar"></param>
        public kare(int kenar)
        {
            KenarUzunlugu = kenar;
            Alan = KenarUzunlugu * KenarUzunlugu;
            Cevre = 4 * KenarUzunlugu;
        }
        public kare() { }
    }
    public class dikdortgen : sekiller
    {
        int a, b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public dikdortgen()
        { }

        public dikdortgen( int kenar1,int kenar2)
        {
            A = kenar1;
            B = kenar2;
            Alan = A * B;
            Cevre = 2 * (A + B);
        }

       


    }

 public class daire : sekiller
        {
            int r;
            


            public int R
            {
                get { return r; }
                set { r = value; }
            }

            public daire()
            {

            }
            public daire(int r)
            {
                R = r;
                Alan = Math.Pow(R,2) * Math.PI;
                Cevre = 2 * Math.PI * R;
            }
        }
}
   

    
    
    

