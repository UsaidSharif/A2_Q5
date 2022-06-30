using System;

namespace A2_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int j,k,l;
            Console.WriteLine("Write Number of elements to be entered in an array!");
            int Number = Convert.ToInt32(Console.ReadLine());

            int[] terms = new int[Number];
            int[] terms1 = new int[Number];
            int[] terms2 = new int[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Write elements to be entered in an array!");
                int value = Convert.ToInt32(Console.ReadLine());
                terms[i] = value;
            }

            Console.WriteLine("Array you made is\n ");

            for (int m = 0; m < Number; m++)
            {
                Console.Write(" " + terms[m] + "\n");
            }

            for (j = 0; j < Number; j++)
            {
                terms1[j] = terms[j];
                terms2[j] = 0;
            }

            for (k = 0; k < Number; k++)
            {
                for (l = 0; l < Number; l++)
                {
                    if (terms[k] == terms1[l])
                    {
                        Console.Write("The duplicate element is: {0} \n", terms[k]);
                        break;
                    }
                    
                }
                
            }

            

        }
    }
}
