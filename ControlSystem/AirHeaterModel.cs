using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem
{
    internal class AirHeaterModel
    {
        //AirHeater variables
        public double theta_t = 22;
        public double Kh = 3.5;
        public double AHModelCalc(double Tenv, double Tout, double u, double InitTs)
        {
            double Ts = InitTs;
            double Tout1;

            Tout1 = Tout * (1 - Ts / theta_t) + (Ts / theta_t) * (Kh * delayU(u) + Tenv);

            return Tout1;
        }

        public double delayU(double u)
        {
            double[] u_delayed = new double[20];

            for (int i = 0; i < u_delayed.Length; i++)
            {
                u_delayed[i] = u;

            }

            return u_delayed[0];
        }
    }


}
