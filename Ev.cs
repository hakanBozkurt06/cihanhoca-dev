using System;

namespace EmlakciLib
{
    public abstract class Ev
    {
        public abstract void Ev_tanim();
        public Ev()
        {
            
        }
        public Ev(int OdaSayisi, int KatNo,int Alan,string Semt)
        {
            this.OdaSayisi = Math.Abs(OdaSayisi);
            this.KatNo = KatNo;
            this.Alan = Alan;
            this.Semt = Semt;
        }

        int OdaSayisi;
        double alan;
        string semt;
        string buyukluk;
        int katno;

        

        public double Alan
        {
            get { return alan; }
            set {
                if (value<50) 
                {
                    throw new Exception("Bu boyutlar devasa!!!");
                }
                alan = Math.Abs(value);
                if (value<50&&value < 75) 
                {
                    this.Buyukluk = "Küçük Ev";
                }

                else if (value < 120)
                {
                    this.Buyukluk = "Orta Büyüklükte Ev";
                }

                else if (value>120)
                {
                    this.Buyukluk = "Büyük Ev";
                }
                else
                {
                    
                }

            }
        }

        public string Buyukluk { get; private set ; }
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        //Auto-Property
        public int KatNo { get=> katno; set=>katno = value; }

        public void SetOdasayisi(int OdaSayisi)=> this.OdaSayisi = Math.Abs(OdaSayisi);
        
        public int GetOdasayisi() => this.OdaSayisi;


        //Full Property: Get ve Set bloklarında çok satırlı işlemler yapmak için kullanılır.

        //private int myVar;

        //public int MyProperty
        //{
        //    get { 
        //        //Başka işlemler yapılabilir
        //        return myVar; }
        //    set { 
        //        //başka işlemler yapılabilir
        //        myVar = value;
        //        //başka işlemler yapılabilir
        //    }
        //}


        public virtual string ToString()
        {
            return $"Evin Odasayisi : {this.OdaSayisi}\nKatNo :{this.KatNo}\nAlani : {this.Alan}\nSemt : {this.Semt}";
        }
        


        //public Ev(string Ram, string Ekran_karti = "")
        //{

        //}
        //public Ev(string Ram, string Ekran_karti, double total_fiyat)
        //{
        //    this.total_fiyat = 1;
        //    sayac1++;
        //}

        //public string Ram { get; set; }
        //public string Ekran_karti { get; set; }
        //public double total_fiyat { get; set; }

        //public static int sayac1;
        //public string EvBilgileri()
        //{
        //    return $"ram:{Ram}\nEkran Kartı:{Ekran_karti}\ntotal fiyat:{total_fiyat}";

        //}
        //public int EvSavac()
        //{
        //    return sayac1;
        //}
    }
}
