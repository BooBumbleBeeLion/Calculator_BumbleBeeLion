using System;
using System.Collections.Generic;
using System.Text;

namespace BumbleBeeLion
{
    public class Calc
    {
        public double Summ(params double[] args)
        {
            double rezult = 0;
            double output = 0;

            for (int i = 0; i < args.Length; i++)
            {
                rezult += args[i];
            }

            output = rezult;
            rezult = 0;

            return output;
        }

        public double Minus(params double[] args)
        {
            double rezult = 0;
            double output = 0;
            rezult = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                rezult -= args[i];
            }

            output = rezult;
            rezult = 0;

            return output;

        }

        public double Multiply(params double[] args)
        {
            double rezult = 0;
            double output = 0;
            rezult = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                rezult *= args[i];
            }

            output = rezult;
            rezult = 0;

            return output;
        }


        public double Division(params double[] args)
        {
            double rezult = 0;
            double output = 0;
            rezult = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                rezult /= args[i];
            }

            output = rezult;
            rezult = 0;

            return output;
        }
    }
}
