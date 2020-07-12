using System;

namespace BumbleBeeLion
{
    class WorkSpace
    {
        string[] split;
        string input;

        double result = 0;
        public  void Space()
        {
            Console.WriteLine("Введите полный пример, отделяя числа и знаки через пробел. Вводите только числа и знаки");

            try
            {
                input = Console.ReadLine(); // Convert.ToString(Console.Read())

                split = input.Split(' ');

                result = Convert.ToDouble(split[0]);
            }
            catch
            {
                Console.WriteLine("Нужно вводить пример корректно, соблюдайте правила ввода \n");
                Space();
            }

            try
            {
                for(int i = 1; i < split.Length; i += 2)
                {
                    Console.WriteLine("Фор сработал i=" + i);
                    switch (split[ i ])
                    {
                        case "+":
                            try
                            {
                                result += Convert.ToDouble(split[ i + 1 ]);   //Convert.ToDouble(split[0]) , Convert.ToDouble(split[i + 1])
                                Console.WriteLine(result);
                            }
                            catch
                            {
                                Console.WriteLine("Не сложилось...");
                                Space();
                            }
                            break;
                        case "-":
                            try
                            {
                                result -= Convert.ToDouble(split[i + 1]);   //Convert.ToDouble(split[0]) , Convert.ToDouble(split[i + 1])
                                Console.WriteLine(result);
                            }
                            catch
                            {
                                Console.WriteLine("Не минусанулось...");
                                Space();
                            }
                            break;
                        case "*":
                            try
                            {
                                result *= Convert.ToDouble(split[i + 1]);   //Convert.ToDouble(split[0]) , Convert.ToDouble(split[i + 1])
                                Console.WriteLine(result);
                            }
                            catch
                            {
                                Console.WriteLine("Не умножилось...");
                                Space();
                            }
                            break;
                        case "/":
                            try
                            {
                                result /= Convert.ToDouble(split[i + 1]);   //Convert.ToDouble(split[0]) , Convert.ToDouble(split[i + 1])
                                Console.WriteLine(result);
                            }
                            catch
                            {
                                Console.WriteLine("Не поделилось...");
                                Space();
                            }
                            break;
                        case "=":
                            //rezult += Convert.ToDouble(split[i - 1]);
                            Console.WriteLine("Результат: " + result);
                            break;
                        default :
                            Console.WriteLine("Канец Дефолт");
                            break;
                    }
                }
                result = 0;
                Array.Clear(split , 0 , split.Length);
                Space();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так...2 \n");
                Space();
            }
        }
    }
}
