using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_gen
{
    class Recursive
    {
        public int factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * factorial(number - 1);
        }
        public void factorialPrintBefore(int number)
        {
            if (number == 0)
            {
                return;
            }
            Console.WriteLine(number + " Before ");
            factorialPrintBefore(number - 1);
        }
        public void factorialPrintAfter(int number)
        {
            if (number == 0)
            {
                return;
            }
            factorial(number - 1);
            Console.WriteLine(number + " After ");
        }

        /*
        * LSD = n%10 To get Reminder;
        * Divisor,Coefficient,Reminder
        * LSD = n/10 To add Reminder;
        * if(n/10) == 0 n will have only one digit.
        */
        internal int sumOfDigits(int number)
        {
            if (number / 10 == 0)
            {
                return number;
            }
            return sumOfDigits(number / 10) + number % 10;
        }
    }
    class BaseConversion
    {
        internal void DecimalToBinary(int number)
        {
            if (number == 0)
            {
                return;
            }
            DecimalToBinary(number / 2);
            Console.Write(number % 2);
        }

        internal void DecimalToOctal(int number)
        {
            if (number == 0)
            {
                return;
            }
            DecimalToOctal(number / 8);
            Console.Write(number % 8);
        }

        internal void DecimalToHexadecimal(int number)
        {
            if (number == 0)
            {
                return;
            }
            DecimalToOctal(number / 16);
            int reminder = number % 16;
            if (reminder < 10)
            {
                Console.Write(reminder);
            }
            else
            {
                Console.Write((char)(reminder - 10 + 'A'));
            }
        }
        internal float PowerOfN(int number, int power)
        {
            if (power == 0)
                return 1;
            return number * PowerOfN(number, power - 1);
        }
        /*
        * GDC Formula please check basic example 9/55 : Quotient = 6 reminer = 1
        * Dividend Divisor Quotient Remainder
        * 55 9 6 1
        * GDC= 1
        * b= 0;
        * GCD(b,a%b)
        */
        internal float GCD(int dividend, int divisor)
        {
            if (divisor == 0)
                return dividend;
            return GCD(divisor, dividend % divisor);
        }
        /* Fibonacci Series Of Items
        * 0Th --> 1St 2nd = (0Th+ 1st) 3rd = (1st +2nd) 4th & So On.. = (Last 2 items addtion)
        * 0 --> 1 -> 1 --> 2 --> 3 & So On…
        * Adtion of last two number
        */
        internal void FibonacciSeries(int firstNumber, int SecondNumber, int expectedLengthOdSeries)
        {
            Console.Write(firstNumber + " ");
            Console.Write(SecondNumber + " ");
            for (int i = 2; i < expectedLengthOdSeries; i++)
            {
                int currentNumber = firstNumber + SecondNumber;
                Console.Write(currentNumber + " ");
                firstNumber = SecondNumber;
                SecondNumber = currentNumber;

            }

        }
        int count = 2, currentNumber = 0;
        public void FibonacciSeriesRecusion(int firstNum, int SecondNum, int expectedLength)
        {
            if (expectedLength <= count)
            {
                Console.Write(firstNum + " ");
                Console.Write(SecondNum + " ");
                Console.WriteLine();
                return;
            }
            if (currentNumber == 0)
            {
                Console.Write(firstNum + " ");
                Console.Write(SecondNum + " ");
            }
            currentNumber = firstNum + SecondNum;
            Console.Write(currentNumber + " ");
            firstNum = SecondNum;
            SecondNum = currentNumber;
            count++;
            FibonacciSeriesRecusion(firstNum, SecondNum, expectedLength);
        }

    }
}
