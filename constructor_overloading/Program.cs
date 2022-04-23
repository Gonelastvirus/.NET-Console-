using System;

namespace constructor_overloading
{
    public class A{

        public  A(){
            Console.WriteLine("Default Constructor");
        }
        public  A(int a){
            Console.WriteLine(a);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
           A obj = new A();
           A obj1 =new A(5);
        }
    }
}
