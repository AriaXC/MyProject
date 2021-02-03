using System;
using System.Collections.Generic;

namespace MyProject
{

    class AllArrAy
    {
        public static void A()
        {
            string abc = "abcd";
            List<string> arr = new List<string>() { "a","b","c"};

            Show(arr, 0, arr.Count);
        }

        public static void Show(List<string> arr,int m,int n)
        {
            if (m < n)
            {
                for (int c = 0; c <= m; c++)
                {
                    Console.Write(arr[c]);
                }
                Console.WriteLine("--");
            }
            for (int i = m; i < n; i++)
            {
                Wrap(ref arr, m, i);
                Show(arr, m + 1, n);
                Wrap(ref arr, i,m);
            }

        }
        public static void Wrap(ref List<string> arr,int i,int j)
        {
            string temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        
    }
}
