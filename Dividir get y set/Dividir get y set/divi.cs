using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividir_get_y_set
{
    internal class dividirclass
    {
        
        private double N1;
        private double N2;

        public double N11 { get => N1; set => N1 = value; }
        public double N21 { get => N2; set => N2 = value; }

      
        public double divicion()
        {
            return (N1 / N2);
        }
    }
}
