using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class length : lengths
    {
        public override double meter_to_Decimeter()
        {
            return meter * 10;
        }
        public override double Decimeter_to_meter()
        {
            return decimeter / 10;
        }
        public override double meter_to_sentimeter()
        {
            return meter * 100;
        }

        public override double sentimeter_to_meter()
        {
            return sentimeter / 100;
        }

        public override double sentimeter_to_milimeter()
        {
            return sentimeter * 10;
        }

        public override double milimeter_to_sentimeter()
        {
            return milimeter / 10;
        }

    }
}
