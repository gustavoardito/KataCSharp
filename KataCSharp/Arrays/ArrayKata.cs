using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.Arrays
{
    public class ArrayKata
    {
        public int[] RotateByPivot(int[] items, int pivotIndex) {

            var itemsRotated = items;

            //if (items.Length == 0)
            //{
            //    throw new Exception("Empty");
            //}
            //else 
            if (pivotIndex < 0 || pivotIndex > items.Length)
            {
                throw new IndexOutOfRangeException();
            }

            var len = items.Length;

            for (int i = 0; i < len; i++)
            {
                //itemsRotated[i] = items[(pivotIndex + i) % len];
                // rotate right
                //var pivot = (pivotIndex - i) % len;
                // rotate left
                var pivot = (pivotIndex - i + len) % len;
                itemsRotated[i] = items[pivot];
            }

            return itemsRotated;
        }

        ////Rotate array to the right of a given pivot
        //public int[] Rotate(int[] x, int pivot)
        //{
        //    if (pivot < 0 || x == null)
        //        throw new Exception("Invalid argument");

        //    pivot = pivot % x.Length;

        //    //Rotate first half
        //    x = RotateSub(x, 0, pivot - 1);

        //    //Rotate second half
        //    x = RotateSub(x, pivot, x.Length - 1);

        //    //Rotate all
        //    x = RotateSub(x, 0, x.Length - 1);

        //    return x;
        //}

        //private int[] RotateSub(int[] x, int start, int end)
        //{
        //    while (start < end)
        //    {
        //        int temp = x[start];
        //        x[start] = x[end];
        //        x[end] = temp;
        //        start++;
        //        end--;
        //    }
        //    return x;
        //}
    }
}
