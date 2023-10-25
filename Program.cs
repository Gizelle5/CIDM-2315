namespace Homework8;
using System.Linq;
class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Test Q2.1
        PrintAllOddNumber(array_2d);

        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }

        // Q1: calculate the sum of elements in a given int_array (4 points)
        public static void ArraySum(int[] int_array)
        {
            int sum = 0;
            foreach (int num in int_array)
            {
                sum += num;
            }
            Console.WriteLine("Sum of elements in int_array: " + sum);
        }

        // Q2.1: given a 2D array, print all the odd elements (2 points)
        public static void PrintAllOddNumber(int[,] array_2d)
        {
            Console.Write("Odd elements in the 2D array: ");
            foreach (int num in array_2d)
            {
                if (num % 2 == 1)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        // Q2.2: given a 2D array, return the sum of all elements (2 points)
        public static int ElementSum(int[,] array_2d)
        {
            int sum = 0;
            foreach (int num in array_2d)
            {
                sum += num;
            }
            return sum;
        }

        // Q2.3: given a 2D array, double its element values and return it (2 points)
        public static int[,] DoubleArray(int[,] array_2d)
        {
            int nRows = array_2d.GetLength(0);
            int nCols = array_2d.GetLength(1);

            int[,] doubledArray = new int[nRows, nCols];

            for (int row = 0; row < nRows; row++)
            {
                for (int col = 0; col < nCols; col++)
                {
                    doubledArray[row, col] = array_2d[row, col] * 2;
                }
            }

            return doubledArray;
        }
    }
