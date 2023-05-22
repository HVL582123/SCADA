using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem
{
    internal class PIDController
    {

        public double z = 0;
        public double setPoint = 20;

        public double PIController(double T_out, double K_p, double T_i, double InitTs)
        {
            double Ts = InitTs;
            double uk;
            //error
            double e = setPoint - T_out;
            
            uk = K_p * e + (K_p / T_i) * z;
            z = z + Ts * e;
            if (uk < 0)
            {
                uk = 0;
                z = 1;
            }
            else if (uk > 5)
            {
                uk = 5;
                z = 100;
            }
            return uk;
        }

       
    }
}
