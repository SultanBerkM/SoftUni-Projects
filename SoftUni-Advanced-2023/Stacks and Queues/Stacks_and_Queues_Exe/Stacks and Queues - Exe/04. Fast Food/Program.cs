using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackLab_sOFTuNI
{
    class Program
    {
        static void Main(string[] args)
        {
            var clients = new Queue<int>();
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int bigggestOrder = orders.Max();

            for (int i = 0; i < orders.Length; i++)
            {
                clients.Enqueue(orders[i]);
            }
            int count = clients.Count;
            for (int i = 0; i < count; i++)
            {
                int current = clients.Peek();

                if (quantityFood - current < 0)
                {
                    Console.WriteLine(bigggestOrder);
                    Console.Write("Orders left: " + string.Join(' ', clients));


                    return;
                }
                quantityFood -= clients.Dequeue();
            }
            Console.WriteLine(bigggestOrder);
            Console.WriteLine("Orders complete");
        }
    }
}
