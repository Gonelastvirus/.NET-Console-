using System;

namespace access_base_class_consructor
{

    class base_class{
        public base_class(string msg){
            Console.WriteLine("Hello"+" "+msg+" "+"This is base class");
        }
    }
    class derive_class:base_class{
        public derive_class(string msg):base( msg)//use base keyword
        { 
             Console.WriteLine("Hello"+" "+msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            derive_class obj = new derive_class("subesh");
            //auto matically invoke derive_class function at with use of base keyword the msg in pass to base class function which invoke automatically
        }
    }
}
