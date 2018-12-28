using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekiller
{
    public class kare : Sekiller
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
}
