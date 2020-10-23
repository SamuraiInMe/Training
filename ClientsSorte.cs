using System;
using static Final.TypeOfClientArray;

namespace Final
{
    public class ClientsSorter
    {
     public int[,] SortMax(int[,] array)
       {
           int i = 0;
           int j = 0;
           int temp = 0;
           int k = 0;
           int n = array.Length / 4;
           for (i = 0; i < n; i++)
           {
               for (j = 0; j < n; j++)
               {
                   for (k = 0; k < n; k++)
                   {
                       for (int l = 0; l < n; l++)
                       {
                           if (array[i,j] > array[k,l])
                           {
                               temp = array[i,j];
                               array[i,j] = array[k,l];
                               array[k,l] = temp;
                           }
                       }
                   }
               }
           }

           return array;
       }
     
     public int[,] SortMin(int[,] array)
       {
           int i = 0;
           int j = 0;
           int temp = 0;
           int k = 0;
           int n = array.Length / 4;
           for (i = 0; i < n; i++)
           {
               for (j = 0; j < n; j++)
               {
                   for (k = 0; k < n; k++)
                   {
                       for (int l = 0; l < n; l++)
                       {
                           if (array[i,j] < array[k,l])
                           {
                               temp = array[i,j];
                               array[i,j] = array[k,l];
                               array[k,l] = temp;
                           }
                       }
                   }
               }
           }

           return array;
       }
    }
}