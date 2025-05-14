using EmlakciLib;

namespace Cihan_Hoca_Emlakci
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //Ev evim = new Ev("ddr5 32gb ram", "RTX5090", 280000);//Ev classından nesne türetildi 
            ////evim: Referans. nesnelerin bellekteki adresini tutarlar.
            ////Ev: Class. Classlar aynı zamanda bir veri tipidir.
            //Ev pc = new Ev("ddr5 32gb ram", "RTX5090", 280000);

            //Console.WriteLine(pc.EvBilgileri());
            //Console.WriteLine("Toplam oluşturulan ev sayısı : "+Ev.sayac1);
            Satilik_Ev ev1 = new(6,12,180,"ankara",100000);
            Satilik_Ev ev2 = new(3, 6, 120, "istanbul", 200000);
            Satilik_Ev ev3 = new(2, 4, 80, "izmir", 300000);

            Kiralik_Ev ev4 = new(1,3,90,"Mamak",10000,20000);
            Kiralik_Ev ev5 = new(3, 5, 170, "Çankaya", 3000, 40000);
            Kiralik_Ev ev6 = new(5, 7, 290, "Safaktepe", 5000, 70000);

            Ev[] evler = { ev1, ev2, ev3, ev4, ev5, ev6 };
          

            for (int i = 0; i < evler.Length; i++)
            {
                if (evler[i] is Satilik_Ev)
                {
                    Satilik_Ev ev10 = (Satilik_Ev)evler[i];
                }
                else if (evler[i] is Kiralik_Ev)
                {
                    Kiralik_Ev ev10 = (Kiralik_Ev)evler[i];
                }

                Console.WriteLine(evler[i].ToString()+"\n");
            }
          


            //try
            //{
            //    Ev evim1 = new();

            //    Console.WriteLine("Oda sayisi giriniz : ");
            //    evim1.SetOdasayisi(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("KatNo sayisi giriniz : ");
            //    evim1.KatNo = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Daire Alanini giriniz : ");
            //    evim1.Alan = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Semt giriniz : ");
            //    evim1.Semt = Console.ReadLine();

            //    Console.WriteLine(evim1.Otoev());
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}




            


        }
        //public int sayac0;
    }

    


}
//new: bellekte nesne yaratmaya yarayan anahtar sözcüktür 
//heapte nesne için yer oluşturulur / Referanslar stackte bulunur .
//Nesne : new ahatar sözcüğü ile heap bölgesinde oluşturulurlar.

//Erişim belirleyiciler(Access Modifiers)
//private : Sadece class içerisinde erişilebilir üyelerdir
//public : Class içerisinde tanımlanan üyeye her yerden erişim sağlar

// CONSTRUCTER: KURUCU METHOD - YAPICI METHOD
// Gorevi: bir classtan nesne turetilirken calisir ve class icindeki fieldlara varsayilan deger atamalarini yapar.

//Her classta mutlaka vardır. Varsayılan olarak parametre almazlar. bu constructerlara default constructer da denir.
//İsimleri class adı ile aynıdır. Farklı isimle tanımlanamazlar
//Geri dönüş tipleri yoktur.

//Classlardan nesne türetildiğinde çalışan ilk metoddur.

//var evim = new Ev {katno = 2, odasayisi = 3};


//Bir class içerisinde static olarak tanımlanan üyelere, class ismi ile erişilir ve bu üyeler program çalıştığı sürece bellekte tututlur nesnelerden bağımsız, class'a ait yapılanmalardır.

//Kapsülleme(Encapsulation) İlkesi: Class içerisinde yapılan işlerin class dışından gizlenmesidir. Örn: Odasayısı fieldı private yapıldı setodasayısı metodu ile kullanılması zorunlu kılındı. Bu metod içine gelen değeri mutlak değerini alarak odasayısı fieldina atıldı ve bu işlemden metodu kullanan kişinin bilgisi olmadı.

// İnternal erişim belirleyicisi yanlızca aynı namespace içerisinden erişebilir .
// Bir classın birden fazla base classı olamaz ve aynı zamanda base classı olmak zorunda değildir

// NameHiding : Türeyen classlarda, base classtaki üyelerin ismi ile aynı isimli bir üye oluşturulursa artık türeyen class referansı ile base classtaki üyeye erişilemez 

// Polymorphisim(Çok Biçimlilik): base classta virtual olarak tanımlanan üyeler, türeyen classlarda override edilerek farklı biçimlerde kullanılabilir.