// See https://aka.ms/new-console-template for more information
using Operators_Exercise;

//// Exercise 1
Console.WriteLine("Select operation:\n" + "1 - Sum\n" + "2 - Subtract\n" + "3 - Multiply\n" + "4 - Divide\n" + "5 - Modulus\n" + "6 - Area of a Circle\n" + "7 - Division and Modulus TEST" );

    int selection = Convert.ToInt32(Console.ReadLine());


if (selection == 6) { //// Exercise 2
    Console.WriteLine("Please input radius");
    double radius = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The area is equal to " + Calc.Area(radius));
}

else if (selection == 7) {
    Console.WriteLine("The quotient of 17 and 4 is: " + NewDiv.Quo(17, 4));
    Console.WriteLine("The remainder of 17 and 4 is: " + NewDiv.Rem(17, 4));
}

else {
    Console.WriteLine("Please input two numbers");

    int input1 = Convert.ToInt32(Console.ReadLine());

    int input2 = Convert.ToInt32(Console.ReadLine());

    switch (selection) {
        case 1:
            Console.WriteLine("The sum is equal to: " + Calc.Sum(input1, input2));
            break;
        case 2:
            Console.WriteLine("The difference is equal to: " + Calc.Sub(input1, input2));
            break;
        case 3:
            Console.WriteLine("The product is equal to:  " + Calc.Mult(input1, input2));
            break;
        case 4:
            Console.WriteLine("The quotient is equal to: " + Calc.Div(input1, input2));
            break;
        case 5:
            Console.WriteLine("The modulus is equal to: " + Calc.Mod(input1, input2));
            break;
    }
}






