using System;

namespace vritual_function
{
    class Program
    {
        class base_class {
            public virtual void show(){
                Console.WriteLine("Base class");
            }
        }
        class derived_class:base_class
        {
            public override  void show(){
                Console.WriteLine("Access from base class");
            }
        }

        static void Main(string[] args)
        {
            base_class obj = new base_class();//derive class object

            obj = new derived_class();//same object is now object of derived class
           obj.show();

        }
    }
}
