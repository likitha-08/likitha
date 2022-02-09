using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class QueueUsingArray
    {
        public static void Main11(string[] args)
        {
            int size = 2;
            Queue queue = new Queue(size);

            int val1 = 4,
                val2 = 5;

            queue.Enqueue(val1);
            queue.Enqueue(val2);

            val1 = queue.Dequeue();
            val2 = queue.Dequeue();

            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }
    }

    public class Queue
    {
        private int[] queue;
        private int position;

        public Queue(int size)
        {
            position = -1;
            queue = new int[size];
        }

        public void Enqueue(int value)
        {
            position++;
            queue[position] = value;
        }

        public int Dequeue()
        {
            int aux = queue[0];

            for (int i = 0; i < position; i++)
            {
                queue[i] = queue[i + 1];
            }

            queue[position] = aux;
            position--;

            return queue[position + 1];
        }
    }
}
