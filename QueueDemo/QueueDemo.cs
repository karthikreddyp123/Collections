using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue('A');
            queue.Enqueue('B');
            queue.Enqueue('C');
            queue.Enqueue('D');

            Console.WriteLine("Current queue: ");
            foreach (char c in queue) Console.Write(c + " ");

            Console.WriteLine();
            queue.Enqueue('E');
            queue.Enqueue('F');
            Console.WriteLine("Current queue: ");
            foreach (char c in queue) Console.Write(c + " ");

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)queue.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)queue.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            
            Console.WriteLine("Current queue: ");
            foreach (char c in queue) Console.Write(c + " ");
            Console.ReadLine();
        }
    }
}
