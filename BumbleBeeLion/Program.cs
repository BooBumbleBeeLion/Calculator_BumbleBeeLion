using System;

namespace BumbleBeeLion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WorkSpace workSpace = new WorkSpace();
            workSpace.Space();
        }


    }
    class WorkSpace
    {
        public void Space()
        {
            Calc calc = new Calc();

            int put = 0;
            int length = 0;
            double[] input = null;

            Console.WriteLine("Какое действие с числами вы хотите выполнить?");
            Console.WriteLine("Если сложить, то напишите '1'");
            Console.WriteLine("Если вычитать, то напишите '2'");
            Console.WriteLine("Если умножить, то напишите '3'");
            Console.WriteLine("Если разделить, то напишите '4'");

            try
            {
                put = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Нужно вводить только целые числа \n");
                Space();
            }

            if (put == 1)
            {
                Console.WriteLine("Сколько чисел вы хотите суммировать?");


                length = Convert.ToInt32(Console.ReadLine());
                input = new double[length];

                Console.WriteLine("Вводите числа поочереди");

                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Ответ по вашему запросу: " + calc.Summ(input));
            }
            else if (put == 2)
            {

            }




        }
    } 

    class Calc : Calculator
    {
        public double Summ(params double[] args)
        {
            double rezult = 0;

            for(int i = 0; i < args.Length; i++)
            {
                rezult += args[i];
            }

            return rezult;
        }

        public double Minus(params double[] args)
        {
            double rezult = 0;
            rezult = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                rezult -= args[i];
            }

            return rezult;
        }

        public double Multiply(params double[] args)
        {
            double rezult = 0;
            rezult = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                rezult *= args[i];
            }

            return rezult;
        }


        public double Division(params double[] args)
        {
            double rezult = 0;
            rezult = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                rezult /= args[i];
            }

            return rezult;
        }




    }

    interface Calculator
    {
        double Summ(params double[] args); // Суммирование

        double Minus(params double[] args); // Вычитание

        double Multiply(params double[] args); // Умножение

        double Division(params double[] args); // Деление   


    }
}
