using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[10];
                Console.WriteLine("Please enter the 10 numbers: ");
                for(int i = 0; i < arr.Length; i++)
                {
                    //Input the numbers
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int n = arr.Length;
                      
                // Sort the array
                Array.Sort(arr);
                int[] nums = new int[10];
                for (int i = 0; i < n - 1;)
                {
                    // A valid pair is found
                    if (arr[i] == arr[i + 1])
                    {                        
                        nums[i] = arr[i];
                        nums[i + 1] = arr[i + 1];
                        // Skip the elements of
                        // the current pair
                        i = i + 1;
                    }
                    // Current elements don't make
                    // a valid pair with any other element
                    else
                    {
                        i++;
                    }
                }                              
                for(int i = 0; i < nums.Length; i++)
                {
                    //Print only the pairs
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
