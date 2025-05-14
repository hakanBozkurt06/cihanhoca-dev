using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciLib
{
    public class Satilik_Ev : Ev
    {
        private int satisFiyat;


        public override void Ev_tanim() {
            Console.WriteLine("Ben bir satilik evim");
        }
        public int SatisFiyat
        {
            get { return satisFiyat; }
            set { satisFiyat = value; }
        }
        public Satilik_Ev(int OdaSayisi, int KatNo, int Alan, string Semt, int SatisFiyat) : base(OdaSayisi, KatNo, Alan, Semt)
        {
            this.satisFiyat =SatisFiyat;
        }

        //public string Otoev()
        //{

        //    return $"{base.Otoev()}\n Satis Fiyati : {this.satisFiyat}";
        //}
        public override string ToString()
        {
            return $"{base.ToString()}\n Satis Fiyati : {this.satisFiyat}";
        }


    }
}
