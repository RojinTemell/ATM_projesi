using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMprojesi
{
   public abstract  class Atm
    {
        public double Hesaptaki_son_miktar { get; set; }

        public double Hesaptaki_miktar { get; set; }

        public double Miktar { get; set; }
        public string Sube_adi { get; set; }
        public string Adres { get; set; }
        public string Metre_Kare { get; set; }

        public abstract double Para_Yatırma();

  
        public abstract double Para_Cekme();

        public virtual void  Bakiye_sorgulama()
        {
            
        }
        
         
        


    }
    public class Xbankatm : Atm

    {
      
        public override double Para_Yatırma( )
        {

        Hesaptaki_son_miktar = Hesaptaki_miktar + Miktar;
            return Hesaptaki_son_miktar;

        }
        public override double Para_Cekme()
        {
           
            Hesaptaki_son_miktar = Hesaptaki_miktar - Miktar;

            return Hesaptaki_son_miktar;
           
        }
        public override void Bakiye_sorgulama()
        {

           this. Hesaptaki_son_miktar = this.Hesaptaki_miktar;

          

        }

    }
    public interface Harc_odeme_islemi
    {
     double Harcodeme();
    }
    public class Ybankatm : Atm,Harc_odeme_islemi

    {
        public const double Harcoranı = 0.1;
        public double Harc_miktari { get; set; }
        public double Harcodeme()
        {
            Harc_miktari = Miktar * Harcoranı;
            return Harc_miktari;
        }

        public override double Para_Yatırma()
        {

            Hesaptaki_son_miktar = Hesaptaki_miktar + Miktar;
            return Hesaptaki_son_miktar;

        }
        public override double Para_Cekme()
        {
            
                Hesaptaki_son_miktar = Hesaptaki_miktar - Miktar;
           
            return Hesaptaki_son_miktar;

        }
        public override void Bakiye_sorgulama()
        {

            this.Hesaptaki_son_miktar = this.Hesaptaki_miktar;



        }

    }

}
