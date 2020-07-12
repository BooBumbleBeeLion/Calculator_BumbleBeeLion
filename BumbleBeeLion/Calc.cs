
//ЭТОТ КЛАСС УЖЕ НЕ НУЖЕН, ЭКСПЕРЕМЕНТИРОВАЛ С ЛОГИКОЙ КАЛЬКУЛЯТОРА

namespace BumbleBeeLion
{
    public class Calc
    {
        public double result = 0;
        double output = 0;
        public double Summ(double number)   // условие params double[] args    double one, double two
        {
            /*for (int i = 0; i < args.Length; i++)
            {
                rezult += args[i];
            }*/

            result += number;

            output = result;
            result = 0;

            return output;
        }

        public double Minus(double number)
        {
            result -= number;

            output = result;
            result = 0;

            return output;

        }

        public double Multiply(double number)
        {
            result *= number;

            output = result;
            result = 0;

            return output;
        }


        public double Division(double number)
        {
            result /= number;

            output = result;
            result = 0;

            return output;
        }
    }
}
