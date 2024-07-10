namespace Homeworkweek2CSC205
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Prod(1, 4));
            Console.ReadKey();
        }
        public static int Prod(int m, int n)
        {
            if (m == n)
            {
                return n;
            }
            else
            {
                int recurse = Prod(m, n - 1);
                int result = n * recurse;
                return result;
            }
        }
    }
}
//Prod(1, 4) Call

//Calls Prod(1, 3)
//Prod(1, 3) Call

//Calls Prod(1, 2)
//Prod(1, 2) Call

//Calls Prod(1, 1)
//Prod(1, 1) Call

//Base case reached, returns 1.
//Returning from Prod(1, 2)

//n = 2
//recurse = 1 (from Prod(1, 1))
//result = 2 * 1 = 2
//Returns 2
//Returning from Prod(1, 3)

//n = 3
//recurse = 2 (from Prod(1, 2))
//result = 3 * 2 = 6
//Returns 6
//Returning from Prod(1, 4)

//n = 4
//recurse = 6 (from Prod(1, 3))
//result = 4 * 6 = 24
//Returns 24

//Main
//|
//| --> Prod(1, 4)
//     |
//     | --> Prod(1, 3)
//          |
//          | --> Prod(1, 2)
//               |
//               | --> Prod(1, 1)-- > returns 1
//               |
//               | --> (n = 2, recurse = 1, result = 2 * 1 = 2)-- > returns 2
//          |
//          | --> (n = 3, recurse = 2, result = 3 * 2 = 6)-- > returns 6
//     |
//     | --> (n = 4, recurse = 6, result = 4 * 6 = 24)-- > returns 24

//Prod multiply every number in between the two numbers including the two numbers (1, 4) as input means (1 * 2 * 3 * 4)

//public class Prod {
//public static void Main(string[] args)
//{
//    Console.WriteLine(Prod(1, 4));
//}
//public static int Prod(int m, int n)
//{
//    if (m == n)
//    {
//        return n;
//    }
//    else
//    {
//        return n * Prod(m, n - 1);
//    }
//}
//}