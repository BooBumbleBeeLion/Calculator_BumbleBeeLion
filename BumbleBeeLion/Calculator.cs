
//ЭТОТ КЛАСС УЖЕ НЕ НУЖЕН, ЭКСПЕРЕМЕНТИРОВАЛ С ЛОГИКОЙ КАЛЬКУЛЯТОРА


namespace BumbleBeeLion
{
    interface Calculator
    {
        double Summ(params double[] args); // Суммирование

        double Minus(params double[] args); // Вычитание

        double Multiply(params double[] args); // Умножение

        double Division(params double[] args); // Деление   


    }
}
