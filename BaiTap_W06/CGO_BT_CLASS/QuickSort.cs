using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_TH01_CLASS
{
    public class QuickSort
    {
        public QuickSort() { }
        public void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                Quick_Sort(arr, left, pivotIndex - 1);
                Quick_Sort(arr, pivotIndex + 1, right);
            }
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp2;
            return i + 1;
        }
    }
}
