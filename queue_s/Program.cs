using System;
using System.Collections.Generic;
namespace queue_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> obj = new Queue<int>();
            obj.Enqueue(1);
            obj.Enqueue(2);
            print(obj);
            Console.WriteLine("Dequeue\n");
            Console.WriteLine(obj.Dequeue());
        }
        public static void print(Queue<int> sp){
            foreach (int s in sp){
                Console.WriteLine(s.ToString()+"|");
            }
        }
    }
}
