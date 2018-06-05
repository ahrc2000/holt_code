using System;
namespace Iinterview_
{
    public class Node
    {
        public void quicksort(int [] arr){
             quicksort(arr, 0, arr.Length);
        }

        public void quicksort(int [] ar, int left, int right){
            if (left > right)
                return ;
            int pivot = (left + right) / 2;
            int index = partition(ar, left, right, pivot);
            quicksort(ar, left, index - 1);
            quicksort(ar, index, right);


        }

        public int partition(int[] arr, int left, int right , int pivot)
        {
            while(left > right){
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right++;

                if(arr[left]>arr[right]){
                    swap(arr, left, right);
                    left++;
                    right--;

                }

            }

            return left;

        }

        public void swap(int[] arr, int left , int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

        }


    }
}
