using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi
{
    abstract class Otomobil
    {
        public Otomobil()
        {
            Yapmak = "";
            Model = "";
            Kilometre = 0;
            Fiyat = 0;
        }

        public Otomobil(string make, string model, int mileage, decimal price)
        {
            Yapmak = make;
            Model = model;
            Kilometre = mileage;
            Fiyat = price;
        }

        public string Yapmak { get; set; }
        public string Model  { get; set; }
        public int Kilometre { get; set; }
        public decimal Fiyat { get; set; }
        public abstract string StepOnIt();


        public override string ToString()
        {
            return "Yapmak: " + Yapmak + "  Model: " + Model + "  Kilometre: " + Kilometre + "  Fiyat: " + Fiyat.ToString("C");
        }
    }
}
