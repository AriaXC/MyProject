using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.C100
{
    class C_1
    {
        //有1、2、3、4个数字，能组成多少个互不相同且无重复数字的三位数？都是多少？
        public static void Start()
        {
            Console.WriteLine(DateTime.UtcNow);
            //FirstPrint();

            SecondPrint();
            Console.WriteLine(DateTime.UtcNow);
        }

        public static void FirstPrint()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5;j++)
                {
                    for (int k = 1; k < 5;k++)
                    {
                        if (i != j && j != k &&i!=k)
                        {
                            Console.WriteLine(i*100+j*10+k);
                        }
                    }
                }
            }
        }

        public static void SecondPrint()
        {
            List<int> arr = new List<int>() { 1,2,3,4};

            // 123 124 234 134
            for (int i = 1; i < 5; i++)
            {
                arr.RemoveAt(i - 1);
                ArrSort(arr, 0);
                arr.Insert(i - 1, i);

            }
        }

        //做一个全排列
        public static void ArrSort(List<int> arr,int i)
        {
            // 123   123 213 321 
            if (i == arr.Count - 1)
            {
                Console.WriteLine(arr[0] * 100 + arr[1] * 10 + arr[2]);

            }
            else
            {
                for (int m = i; m < arr.Count; m++)
                {
                    Swap(arr, i,m);
                    ArrSort(arr, i + 1);
                    Swap(arr, m,i);
                }
            }
        }

        public static void Swap(List<int> arr ,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
