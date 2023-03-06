using System;

namespace Operators_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring all the variables ALL THE VARIABLES
            int multInt = (2 * 3);
            int addInt = (2 + 3);
            short multShort = (3 * 4);
            short addShort = (9 + 4);
            long multLong = (12 * 9);
            long addLong = (109 + 206);
            float multFloat = (3 * 5);
            float addFloat = (12 + 5);
            double multDoub = (2.3 * 5.2);
            double addDoub = (5.3 + 4.9);
            decimal multDec = (5.7m * 3.5m);
            decimal addDec = (4.8m + 2.9m);

            //writes the min and max of the numbers
            Console.WriteLine(Math.Min(multInt, addInt));
            Console.WriteLine(Math.Max(multInt, addInt));
            Console.WriteLine(Math.Min(multShort, addShort));
            Console.WriteLine(Math.Max(multShort, addShort));
            Console.WriteLine(Math.Min(multLong, addLong));
            Console.WriteLine(Math.Max(multLong, addLong));
            Console.WriteLine(Math.Min(multFloat, addFloat));
            Console.WriteLine(Math.Max(multFloat, addFloat));
            Console.WriteLine(Math.Min(multDoub, addDoub));
            Console.WriteLine(Math.Max(multDoub, addDoub));
            Console.WriteLine(Math.Min(multDec, addDec));
            Console.WriteLine(Math.Max(multDec, addDec));

            //compares variables
            bool isIntGreater = (multInt > addInt);
            bool isShortGreater = (multShort > addShort);
            bool isLongGreater = (multLong > addLong);
            bool isFloatGreater = (multFloat > addFloat);
            bool isDoubGreater = (multDoub > addDoub);
            bool isDecGreater = (multDec > addDec);

            //makes a line break
            Console.WriteLine();

            //writes the result of which variable is greater
            Console.WriteLine($"{multInt} is greater than {addInt}?");
            Console.WriteLine($"{isIntGreater}");
            Console.WriteLine($"{multShort} is greater than {addShort}?");
            Console.WriteLine($"{isShortGreater}");
            Console.WriteLine($"{multLong} is greater than {addLong}?");
            Console.WriteLine($"{isLongGreater}");
            Console.WriteLine($"{multFloat} is greater than {addFloat}?");
            Console.WriteLine($"{isFloatGreater}");
            Console.WriteLine($"{multDoub} is greater than {addDoub}?");
            Console.WriteLine($"{isDoubGreater}");
            Console.WriteLine($"{multDec} is greater than {addDec}?");
            Console.WriteLine($"{isDecGreater}");
        }
    }
}
