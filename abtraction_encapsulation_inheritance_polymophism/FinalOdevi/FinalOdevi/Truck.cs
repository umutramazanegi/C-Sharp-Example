using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi
{
    class Truck: Otomobil
    {
        public Truck(string make, string model, int mileage, decimal price)
            : base(make, model, mileage, price)
        {
            DortTekerlektenCekis = false;
            Dizel = false;
        }
        public Truck(string make, string model, int mileage, decimal price, bool isFourWheelDrive, bool isDiesel)
            : base(make,model,mileage,price)
        {
            DortTekerlektenCekis = isFourWheelDrive;
            Dizel = isDiesel;
        }

        public bool DortTekerlektenCekis { get; set; }
        public bool Dizel { get; set; }

        public override string StepOnIt()
        {
            if (Dizel)
            {
                return Yapmak + " " + Model + " kömür yuvarlanıyor!";
            }
            else
            {
                return Yapmak + " " + Model + " gürlemeli gider ";
            }
        }
        public override string ToString()
        {
            return "Yapmak: " + Yapmak + "  Model: " + Model + "  Kilometr: " + Kilometre + "  Fiyat: " + Fiyat.ToString("C")
                + " Dort Tekerlekten Cekis: " + DortTekerlektenCekis + " Dizel:: " + Dizel;
        }
    }
    
}
