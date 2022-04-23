/*

Qu 1: You are assigning to develop a project in which you have to achieve following goals.

    Write a program for creating Laptop.
    Name, Price, Processor, Ram and Hard drive should be defined in base class as constant.
    You need to inherit these functionalities in your program and Print Details.
    All the laptop should have different name, price, processor, ram and hard drive.


*/

using System;

namespace inheritence
{
    class Program
    {
        class base_class{
               public const string i3="i3";
               public const string i5="i5";
               public const string i7="i7";

               public const string Ram2GB="2GB";
               public const string Ram4GB="4GB";
               public const string Ram8GB="8GB";

               public const string price1000="1000";
                public const string price2000="2000";
                public const string price3000="3000";

                public const string Lenovo="lenovo";
                public const string Dell="Dell";
                public const string Hp ="Hp";

        }
        class derive_class:base_class{
            public void printdetails(string name,string price,string RAM, string processor){
                Console.WriteLine("Name:"+name);
                Console.WriteLine("Price"+price);
                Console.WriteLine("RAM"+RAM);
                Console.WriteLine("Processor"+processor);
            }
        }
        static void Main(string[] args)
        {
            derive_class obj = new derive_class();
            obj.printdetails(derive_class.Lenovo,derive_class.price1000,derive_class.Ram2GB,derive_class.i3);
            Console.WriteLine("#---------------------------------------------------#");
            obj.printdetails(derive_class.Dell, derive_class.price2000,derive_class.Ram4GB, derive_class.i5);
            Console.WriteLine("#-----------------------------------------------------------------#");
            obj.printdetails(derive_class.Hp,derive_class.price3000,derive_class.Ram8GB,derive_class.i7);
            Console.WriteLine("#-------------------------------------------------------------------#");
        }
    }
}
