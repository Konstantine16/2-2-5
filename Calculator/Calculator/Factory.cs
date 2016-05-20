using System;
using calculator;

namespace Calculator
{
    public static class Factory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "button1":
                    return new Addition();
                case "button2":
                    return new Subtraction();
                case "button4":
                    return new Multiplacation();
                case "button3":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}