using System;


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

            daire da = new daire(3);
            Console.WriteLine($"DAİRE Cevresi: {da.Cevre}  Alani : {da.Alan}");

            KarePrizma prizma = new KarePrizma(5, 5);
            Console.WriteLine($"Prizma Alani: {prizma.Alan}  Hacmi : {prizma.Hacim}");
           
            Silindir silindir = new Silindir(3,3);
            Console.WriteLine($"Silindirin Alani: {silindir.Alan}  Hacmi : {silindir.Hacim}");
            Console.ReadLine();



        }

    }

    interface Isekil
    {

        double Alan { get; set; }
        double Cevre { get; set; }
        double Hacim { get; set; }

        void Yazdir();

    }
    
   

   
}
   

    
    
    

