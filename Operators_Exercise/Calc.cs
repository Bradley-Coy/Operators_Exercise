using System;
namespace Operators_Exercise;
    public class Calc
    {
        public static int Sum(int a, int b) {
            return a + b;
        }

        public static int Sub(int a, int b) {
            return a - b;

        }
        public static int Mult(int a, int b) {
            return a * b;

        }
        public static int Div(int a, int b) {
            return a / b;

        }
  
        public static int Mod(int a, int b) {
            return a % b;

        }

        public void NewDiv(int a, int b) {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{ a } / { b } is { quotient } remainder { remainder }");
        }

    }



