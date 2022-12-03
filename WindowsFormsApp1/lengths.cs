using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class lengths
    {
        public double meter { get; set; }
        public double decimeter { get; set; }
        public double sentimeter { get; set; }
        public double milimeter { get; set; }
        public virtual double meter_to_Decimeter()
        {
            return meter * 10;
        }
        public virtual double Decimeter_to_meter()
        {
            return decimeter / 10;
        }
        public virtual double meter_to_sentimeter()
        {
            return meter * 100;
        }

        public virtual double sentimeter_to_meter()
        {
            return sentimeter / 100;
        }

        public virtual double sentimeter_to_milimeter()
        {
            return sentimeter * 10;
        }

        public virtual double milimeter_to_sentimeter()
        {
            return milimeter / 10;
        }
    }
}
