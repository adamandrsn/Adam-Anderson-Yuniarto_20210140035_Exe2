using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class MergeSort
    {
        static public void MainMerge(int[] numbers, int low, int mid, int high) 
        {
            int[] Adam = new int[25];
            int n, AY, k, i;
            AY = (mid + 1);
            i = low;
            k = low;

            while ((low <= AY) && (mid <= high))
            {
                if (numbers[low] <= numbers[mid])
                    Adam[i++] = numbers[low++];
                else
                    Adam[i++] = numbers[mid++];
            }
            while (low <= AY)
                Adam[i++] = numbers[low++];
            while (mid <= high)
                Adam[i++] = numbers[mid++];
            for (n = 0; n < k; n++)
            {
                numbers[high] = Adam[high];
                high--;
            }
        }
        static public void SortMerge(int[] numbers, int low, int high)
        {
            int mid;
            if (high > low)
            {
                mid = (high + low) / 2;
                SortMerge(numbers, low, mid);
                SortMerge(numbers, (mid + 1), high);
                MainMerge(numbers, low, (mid + 1), high);
            }
        }
        static void Main(string[] args) 
        {
            Console.Write("\nExercise 2");
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];
            for (int n = 0; n < max; n++)
            {
                Console.Write("\nEnter [" + (n + 1).ToString() + "] element: ");
                numbers[n] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input int array : ");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            { }
        }
    }
}
