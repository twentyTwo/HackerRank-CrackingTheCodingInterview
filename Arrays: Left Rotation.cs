using System;
using System.Collections.Generic;
using System.Linq;

namespace HR
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            bool isFirst = true;

            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                    queue.Enqueue(a[i]);
                }
                else
                {
                    if (isFirst == false) Console.Write(" {0}", a[i]); 
                    else
                    {
                        isFirst = false;
                        Console.Write(a[i]);
                    }                  
                }
                
            }

            while (queue.Any())
            {
                if (isFirst == false) Console.Write(" {0}", queue.Peek());                
                else
                {
                    isFirst = false;
                    Console.Write(queue.Peek()); 
                }
                
                queue.Dequeue();
            }
        }
    }
}
