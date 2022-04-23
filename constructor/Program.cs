/*

class yeah
{

//constructor: the name should be same as class name, it automatically invoked when object is created
public yeah(){}

}

yeah obj = new yeah();

Note: child class can constructor of base class using base keyword
class base{
    public base(string str){

    }
}
class child:base{
    public child(string str):base (str){ }
}

*/
using System;

namespace constructor
{
    class Program
    {
        class A{
            public A(){
                Console.WriteLine("Class Constructor");
            }
        }
        static void Main(string[] args)
        {
            A obj = new A();
        }
    }
}
