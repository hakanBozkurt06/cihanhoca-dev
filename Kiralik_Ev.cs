using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciLib
{
    public class Kiralik_Ev : Ev
    {
        private int kiraFiyat;
        private int depozito;

        public override void Ev_tanim()
        {
            Console.WriteLine("Ben bir kiralik evim");
        }
        public int KiraFiyat
        {
            get { return kiraFiyat; }
            set { kiraFiyat = value; }
        }
        public int Depozito
        {
            get { return depozito; }
            set { depozito = value; }
        }
        public Kiralik_Ev() 
        { 
            
        }
        public Kiralik_Ev(int OdaSayisi, int KatNo, int Alan, string Semt, int kirafiyat, int depozito) : base(OdaSayisi,KatNo,Alan,Semt)
        {
           
            this.KiraFiyat = kirafiyat;
            this.Depozito = depozito;
            base.SetOdasayisi(OdaSayisi);            
        }
        //public new string Otoev()
        //{

        //    return $"{base.Otoev()}\n Kira Fiyati : {this.KiraFiyat}\nDepozito : {this.Depozito}";
        //}
        public override string ToString()
        {
            return $"{base.ToString()}\n Kira Fiyati : {this.KiraFiyat}\nDepozito : {this.Depozito}";
        }
    }
}

