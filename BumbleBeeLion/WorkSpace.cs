using System;
using System.Collections.Generic;
using System.Text;

namespace BumbleBeeLion
{
    class WorkSpace
    {
        int put = 0;

        string cycle;
        string stop;
        
        List<double> inputList = new List<double>();
        double[] input = null;

        public void Space()
        {
            Calc calc = new Calc();

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
                Console.WriteLine("Вводите все числа которые нужно сложить");
                Console.WriteLine("Когда введёте все числа, напишите команду '=' без кавычек с новой строки");
                Console.WriteLine("Вводите числа поочереди");

                while (stop != "=")
                {
                    cycle = Console.ReadLine();

                    if (cycle == "=")
                    {
                        break;
                    }
                    else
                    {
                        inputList.Add(Convert.ToDouble(cycle));
                    }
                }
                cycle = "go";

                input = inputList.ToArray();
                inputList.Clear();

                Console.WriteLine("Ответ по вашему запросу: " + calc.Summ(input));
            }
            else if (put == 2)
            {
                Console.WriteLine("Сначала введите уменьшаемое число, а дальше вычитаемое?");
                Console.WriteLine("Когда введёте все числа, напишите команду '=' без кавычек с новой строки");
                Console.WriteLine("Вводите числа поочереди");

                while (stop != "=")
                {
                    cycle = Console.ReadLine();

                    if (cycle == "=")
                    {
                        break;
                    }
                    else
                    {
                        inputList.Add(Convert.ToDouble(cycle));
                    }
                }
                cycle = "go";

                input = inputList.ToArray();
                inputList.Clear();

                Console.WriteLine("Ответ по вашему запросу: " + calc.Minus(input));
            }
            else if (put == 3)
            {
                Console.WriteLine("Введите числа, которые хотите перемножить");
                Console.WriteLine("Когда введёте все числа, напишите команду '=' без кавычек с новой строки");
                Console.WriteLine("Вводите числа поочереди");

                while (stop != "=")
                {
                    //input[i] = Convert.ToDouble(Console.ReadLine());
                    cycle = Console.ReadLine();

                    if (cycle == "=")
                    {
                        break;
                    }
                    else
                    {
                        inputList.Add(Convert.ToDouble(cycle));
                    }
                }
                cycle = "go";

                input = inputList.ToArray();
                inputList.Clear();

                Console.WriteLine("Ответ по вашему запросу: " + calc.Multiply(input));
            }
            else if (put == 4)
            {
                Console.WriteLine("Сначала введите Делимое, а дальше Делители");
                Console.WriteLine("Когда введёте все числа, напишите команду '=' без кавычек с новой строки");
                Console.WriteLine("Вводите числа поочереди");

                while (stop != "=")
                {
                    //input[i] = Convert.ToDouble(Console.ReadLine());
                    cycle = Console.ReadLine();

                    if (cycle == "=")
                    {
                        break;
                    }
                    else
                    {
                        inputList.Add(Convert.ToDouble(cycle));
                    }
                }
                cycle = "go";

                input = inputList.ToArray();
                inputList.Clear();

                Console.WriteLine("Ответ по вашему запросу: " + calc.Division(input));
            }
            else Console.WriteLine("Такого решения пока что нет");

            Console.WriteLine("");

            Space();


        }
    }
}
