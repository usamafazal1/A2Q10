using System;

namespace A2Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* arr1 is for initial array
             * arr2 is for evens
             * arr3 for odds
             * j, k are index positions of arr2, arr3 respectively
             * values of array length are arbitrary, arrays are filled later
             */
            int[] arr1 = new int[100];
            int[] arrEven = new int[100];
            int[] arrOdd = new int[100];
            int i, j = 0, k = 0, n;


            Console.Write("\n\nProgram to separate odd and even integers in separate arrays\n");

            //ask for the number of elements to store in array; that number is stored in variable n
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            //asking for input of numbers to be put in the initial array
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                //for displaying, asking for number to be entered
                Console.Write("element - {0} : ", i);
                //storing in array
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arrEven[j] = arr1[i];
                    j++;
                }
                else
                {
                    arrOdd[k] = arr1[i];
                    k++;
                }
            }

            
            //printing the even and odd arrays:
            Console.Write("\nThe Even elements are : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arrEven[i]);
            }

            Console.Write("\nThe Odd elements are :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arrOdd[i]);
            }
            Console.Write("\n\n");
        }
    }
}
