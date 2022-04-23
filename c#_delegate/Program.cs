using System;

namespace c__delegate
{
    public class test{
        //declaration
       public delegate int calculator(int a, int b);
        public int add(int x, int y){
            return x+y;
        }
        public int sub(int x , int y){
            return x-y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         test obj = new test();
         //Instantiation
         test.calculator a1 = new test.calculator(obj.add);
         test.calculator a2= new test.calculator(obj.sub);
         //invocation 
        Console.WriteLine(a1(5,4));
        Console.WriteLine(a2(5,4));
        }
    }
}
