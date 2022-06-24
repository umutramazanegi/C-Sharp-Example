using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            
            Araba myAuto1= new Araba();
            myAuto1.Yapmak = "Cevy";
            myAuto1.Model = "Chevette";
            myAuto1.Kilometre = 93000;
            myAuto1.Fiyat = 575m;
            myAuto1.Kapi = 2;

            lstDisplay.Items.Add(myAuto1);
            lstDisplay.Items.Add(myAuto1.StepOnIt());

            Araba myAuto2 = new Araba ("Ford", "Taurus", 87395, 2134.17m,4);
        //    lstDisplay.Items.Add(myAuto2);
         //   lstDisplay.Items.Add(myAuto2.StepOnIt());

            Araba myCar1 = new Araba();
            myCar1.Yapmak = "AMC";
            myCar1.Model = "Pacer";
            myCar1.Kilometre = 13982;
            myCar1.Fiyat = 475m;
            myCar1.Kapi = 3;

        //    lstDisplay.Items.Add(myCar1);
        //    lstDisplay.Items.Add(myCar1.StepOnIt());

            Araba myCar2 = new Araba("Toyota", "Celica", 64875, 700m, 2);

         //   lstDisplay.Items.Add(myCar2);
         //   lstDisplay.Items.Add(myCar2.StepOnIt());

            Truck myTruck1 = new Truck("Chevy", "Silverado", 35000, 47000m);
            Truck myTruck2 = new Truck("Ford", "F=350", 822000, 73000m, true, true);

          //  lstDisplay.Items.Add(myTruck1);
          //  lstDisplay.Items.Add(myTruck1.StepOnIt());
          //  lstDisplay.Items.Add(myTruck2);
          //  lstDisplay.Items.Add(myTruck2.StepOnIt());

            List<Otomobil> myAutomobiles = new List<Otomobil>();
            myAutomobiles.Add(myAuto1);
            myAutomobiles.Add(myAuto2);
            myAutomobiles.Add(myCar1);
            myAutomobiles.Add(myCar2);
            myAutomobiles.Add(myTruck1);
            myAutomobiles.Add(myTruck2);

            foreach (Otomobil auto in myAutomobiles)
            {
                lstDisplay.Items.Add(auto);
                lstDisplay.Items.Add(auto.StepOnIt());

            }

        }
    }
}
