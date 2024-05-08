using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zadelqne na pamet 
            Console.WriteLine("kolko chisla she vuvejdash");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            // vhod 
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            // izhod
            for (int index  = 0; index < list.Count; index++)
            {
                Console.WriteLine("list[{0}] = {1}" , index-1, list[index]);
            }
            // izhod 2

               //for (int index = 0; index < list.Count - 1; index++)

               //{
               // if (list[index] < 0 )
               // {
               //    list.Remove(index);
               //     index--;
               //   Console.Write("list[{0}] = {1}", index + 1, list[index]); 
               // }
               //}

            // izhod 3
            for (int index = 0; index < n- 1; index++)
            {

                if (list[index] != (list[n-1] ))
                {
                    //list.Remove(index);
                    //index--;
                    Console.Write(list[index]);
                }

                if (list[index] == (list[n - 1 ] )) 
                    
                {
                  //  list.RemoveAt (index);
                    //index--;
                }
                Console.Write("list[{0}] = {1}", index + 1, list[index]);
            }
            int[] arr = new int[] { 3, 4, 1, 5, 6, 1, };
                for (int i = 0 ; i < list.Count; i++)
            {
                for (int j = 0 ; j < list.Count ; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int slapVar = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = slapVar;
                    }
                }
            }
              
        }
    }
}
