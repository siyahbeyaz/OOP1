using System;


namespace interfaceOrnek
{

    class Program
    {
        static void Main(string[] args)
        {
            //Sınıflar türetilip değerler verilip sınıflar altındaki metotlar çağrılıyor.
            Otomobil Otomobil1 = new Otomobil();
            Otomobil1.Kasa = "Sedan";
            Otomobil1.Marka = "Anadol";
            Otomobil1.Model = "1978";
            Otomobil1.Yakit = "LPG";
            Otomobil1.HareketEt();
            Otomobil1.HizYap();
            Otomobil1.OzellikGoster();

            Kamyon Kamyon1 = new Kamyon();
            Kamyon1.Ton = 30;
            Kamyon1.Marka = "Scania";
            Kamyon1.Model = "2015";
            Kamyon1.Yatak = "Evet";
            Kamyon1.HareketEt();
            Kamyon1.YukTasi();
            Kamyon1.OzellikGoster();

            Otobus Otobus1 = new Otobus();
            Otobus1.KoltukSayi = 60;
            Otobus1.Marka = "Mercedes";
            Otobus1.Model = "2015";
            Otobus1.KatSayisi = 2;
            Otobus1.HareketEt();
            Otobus1.YolcuTasi();
            Otobus1.OzellikGoster();

            Console.ReadLine();
        }
        //Temel sınıf oluşturulup IHareketEdebilirAble isimli interfaceye bağlanıyor.
        class TasitBase : IHareketEdebilirAble
        {
            //Temel sınıfa türetilen sınıflardan erişilebilecek şekilde Marka ve Model isminde 2 özellik tanımlanıyor.
            public string Marka { get; set; }
            public string Model { get; set; }
            //Temel sınıfa türetilen sınıflardan erişilecebilecek şekilde public olarak HareketEt metotdu tanımlanıyor.
            public void HareketEt()
            {
                Console.WriteLine("Ben bir taşıtım ve hareket edebilirim.");
            }
        }

        //Otomobil sınıfı TasitBase isimli sınıftan miras alarak türetiliyor ve IHizYapabilirAble arayüzü ekleniyor.
        class Otomobil : TasitBase, IHizYapabilirAble
        {
            //Otomobil sınıfına özel Kasa ve Yakit isminde iki özellik ekleniyor.
            //Dolayısı Otomobil sınıfı hem temel sınıftaki hem de burada tanımlanan özelliklere erişebilecek.
            public string Kasa { get; set; }
            public string Yakit { get; set; }
            //Otomobil sınıfına HizYap metodu tanımlanıyor.
            public void HizYap()
            {
                Console.WriteLine("Ben bir otomobilim ve hız yapabilirim.");
            }
            //Özellik göster metodu tanımlanarak hem Temel sınıftan hem de bu sınıf altında tanımlanan özellikler ekrana yazdırılıyor.
            public void OzellikGoster()
            {
                Console.WriteLine("\n---ÖZELLİKLER---\n Kasa \t:{0} \n Marka \t:{1} \n Model \t:{2} \n Yakıt \t:{3} \n", Kasa, Marka, Model, Yakit);
            }

        }
        //Kamyon ve Otobüs sınıfında yapılan işlemler bire bir Otomobil sınıfı ile aynı olduğu için bu bölümde detay paylaşmıyorum.
        class Kamyon : TasitBase, IYuktasiyabilirAble
        {
            public int Ton { get; set; }
            public string Yatak { get; set; }

            public void YukTasi()
            {
                Console.WriteLine("Ben bir kamyonum ve yük taşıyabilirim.");
            }

            public void OzellikGoster()
            {
                Console.WriteLine("\n----ÖZELLİKLER---\n Ton \t:{0} \n Yatak \t:{1} \n Model \t:{2} \n Marka \t:{3} \n", Ton, Yatak, Model, Marka);
            }
        }
        class Otobus : TasitBase, IYolcuTasiyabilirAble
        {
            public int KoltukSayi { get; set; }
            public int KatSayisi { get; set; }
            public void YolcuTasi()
            {
                Console.WriteLine("Ben bir otobüsüm ve yolcu taşıyabilirim.");
            }
            public void OzellikGoster()
            {
                Console.WriteLine("\n----ÖZELLİKLER---\n Koltuk\t:{0} \n Kat \t:{1} \n Model \t:{2} \n Marka \t:{3} \n", KoltukSayi, KatSayisi, Model, Marka);
            }
        }
    }
    //IHizYapabilirAble isimli interface tanımlanarak kullanıldığı yerlerde (Otomobil Sınıfı)
    //HizYap isimli metotdun Otomobil sınıfı altında uygulanmasını zorunlu hale getiriyor.
    //Diğer interface tanımlama işlemlerinde de diğer sınıflar için benzer işlemler yapılıyor.
    interface IHizYapabilirAble
    {
        void HizYap();
    }

    interface IYuktasiyabilirAble
    {
        void YukTasi();
    }
    interface IYolcuTasiyabilirAble
    {
        void YolcuTasi();
    }
    //IHareketEdebilirAble isimli interface tanımlanarak kullanıldığı sınıfı içerisinde (TasitBase)
    //Marka ve Model özellikleri ile HareketEt metodunun kullanımını zorunlu hale getiriyor.
    //Bu özellik ya da metoların sınıf içerisinde kullanılmaması durumunda derleme anında hata verecektir.
    interface IHareketEdebilirAble
    {
        string Marka { get; set; }
        string Model { get; set; }
        void HareketEt();
    }
}

