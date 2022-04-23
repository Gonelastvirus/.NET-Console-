using System;
using System.Collections.Generic;
namespace generic_stack
{
    class test{
         public  void print(Stack<int> sp)
        {
            foreach (int s in sp ){
                Console.WriteLine(s.ToString()+"|");
            }
        }
    }
    
    class Program
    {

        static void Main(string[] args)
        {
            Stack<int> obj= new Stack<int>();
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            test obj1=new test();
            obj1.print(obj);
            Console.WriteLine("Data is pushed");
            Console.WriteLine(obj.Peek());
        }
       

    }
}
