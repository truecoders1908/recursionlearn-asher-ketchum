using System;

namespace recursionLearn
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));
            Console.WriteLine(S(11));
            
        }
        //The process in which a function calls itself directly or indirectly is called recursion and the corresponding function is called as recursive function.
        //credit: https://www.geeksforgeeks.org/recursion/
        static int Factorial(int n)         //New method for Factorials                                                              <       
        {                                    //                                                                                      | 
            if (n == 0)                     //IF the int n is equal to 0 return 1                                                    |   
            {                               //                                                                                       |
                return 1;                   //return one                                                                             |
            }                              //                                                                                        |
            //                                                                                                                       |
            // recursive solution (as opposed to iterative)                                                                          |
            return n * Factorial(n - 1);    //[Factorial] is the recursive part in the solution because its refering back to it self /

            // e.g.
            // 5! = 5 * 4!
            //  4! = 4 * 3!
            //   3! = 3 * 2!
            //    2! = 2 * 1!
            //     1! = 1 * 0!
            //      0! = 1 (because math)
        }
        static int S(int n)
        {
            if (n == 1)
                return 5;
            else
                return 5 * n + S(n - 1);
        }
    }
}
