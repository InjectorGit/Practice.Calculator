using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class ClassFactoryMethod
    {
        public static calc calcMethod(int count)
        {
            switch (count)
            {
                case 1:
                    return new PLUS();
                case 2:
                    return new MINUS();
                case 3:
                    return new DIVITION();
                case 4:
                    return new MULTIPLY();
                case 5:
                    return new MINIMUM();
                default:
                    return new PLUS();

            }

        }
    }
    interface calc
    {
        double Calculate(double firstValue, double secondValue);
    }
    public class PLUS : calc
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
    public class MINUS : calc
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
    public class DIVITION : calc
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
    public class MULTIPLY : calc
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
    public class MINIMUM : calc
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue > secondValue)
            {
                return secondValue;
            }
            else if (firstValue < secondValue)
            {
                return firstValue;
            }
            else if (firstValue == secondValue)
            {
                return firstValue;
            }
            return firstValue; // необходимая часть.
        }
    }
}




