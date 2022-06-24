using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi
{
    class Araba : Otomobil
    {
        public Araba()
        {
            Kapi = 2;
        }

        public Araba(string make, string model, int mileage, decimal price, int doors) : base(make, model, mileage,price)
        {
            Kapi = doors;
        }

        public int Kapi { get; set; }

        public override string StepOnIt()
        {
            return Yapmak + " " + Model + " cok hizli gider";
        }

        public override string ToString()
        {
            return "Yapmak: " + Yapmak + "  Model: " + Model + "  Kilometre: " + Kilometre + "  Fiyat: " + Fiyat.ToString("C") + " Kapi: " + Kapi;
        }
    }
}
