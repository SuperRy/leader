using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Leadersoftware
{
    class runningNumbers
    {

        

        // for pre tax and after tax
        public static double investment(double total, double time, double rate)
        {
            double fu = total*Math.Pow(1+rate,time);
            return fu;       
        }

        // Ss
        public static double[] ss(double ss1)
        {
            double[] ssr = new double[24];
            ssr[0] = ss1;
            for (int y = 1; y < 23; y++)
            {
                ssr[y] = ssr[y - 1] * (1 + .025);
            }
            return ssr;
        }


        public static double futuresaving(double depo, double rate, double time)
        {
            // double fv = ((depo / rate)) * ((Math.Pow(1 + rate, time) - 1)) * ((1 + rate));
            double fv = depo * ((Math.Pow(1 + rate, time) - 1) / rate) * (1 + rate);
            return fv;
            
        }

        public static double[] overtimess(double starting, double intrestrate) // Client / spouce SS
        {
            double[] runtime = new double[24];
            int b = 0;
            runtime[0] = starting;
            for (int i = 1; i <= 23; i++)
            {
                runtime[i] = runtime[b] + (runtime[b] * intrestrate);
                b++;
            }
            return runtime;
        }
      
        public static double pv( double rate, int time, double value)// present value
        {

            double pvn = value * Math.Pow(1 + (rate / 2), time);
            return pvn;
        }


        
    }
}               //=-1*FV(!D17,!D10-!D8,0,!D22,1)
