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

    //// Exercise 2 - Calculate area of a circle with a given radius

        public static double Area(double r) {
            return Math.PI * Math.Pow(r, 2);
        }

    }



