using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); 

            Console.WriteLine(" izvejda chetni");
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]%2== 0)
                 Console.WriteLine(nums[i]);
            }
            //izhod 2  
            //List<int> list = new List<int>();
            //int start = 0;
            //int Length = 0;
            //for (int index = 0;index < list.Count; index++)
            //{

            //    if (nums[index] == 0 )
            //    {
            //        list.Length ++;
            //    }
            //    else
            //    {

            //        int bestStart = 0;
            //        int bestLength = 0;
            //    }
            //}
            //for (int index = 0; index < list.Length - 1; index++)
            // Console.WriteLine("list[{0}] = {1}", index - 1, nums[index]);

            Console.WriteLine(" izvejda otricatelni ");                                      
            for (int i = 0; i < nums.Count ; i++)
            {
                if (nums[i] == 2)
                    Console.WriteLine(nums[i]); 
            }
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            

        }
    }
}
