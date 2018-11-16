using System;

namespace bubble_sort

{

    class Program

    {

        private static void Main(string[] args)

        {

            Program p = new Program();

            int[] arr = new int[50]; // declaring array to store elements

            int n;

            Console.WriteLine("Enter no of elements you want to store in an array");

            n = Convert.ToInt32(Console.ReadLine()); // taking input from user

            Console.WriteLine("Enter elements in an array");
         

            for (int i = 1; i <= n; i++)

            {

               
                try
                {
                    8arr[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid numerical value!");
             
                    arr[i] = int.Parse(Console.ReadLine());
                }

            }

            p.bubblesort(arr, n);

            Console.ReadKey();//It does not require the user to press enter before returning.

        }
        //start of algorithm
        public void bubblesort(int[] arr, int n)

        {

            int temp;

            for (int i = 1; i <= n; i++)

            {

                for (int j = 1; j <= n - i; j++)

                {

                    if (arr[j] > arr[j + 1])

                    {

                        temp = arr[j];

                        arr[j] = arr[j + 1];

                        arr[j + 1] = temp;

                    }

                }//end of inner loop 

            }//end of outer loop

            Console.WriteLine("Array after sorting them");

            for (int i = 1; i <= n; i++)

            {

                Console.WriteLine(arr[i]);

            }

        }

    }

}
