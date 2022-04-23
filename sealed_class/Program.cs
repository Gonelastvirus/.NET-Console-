using System;
//A sealed class cannot be a base class
//Child class cannot inherit sealed class. 
namespace sealed_class
{
    sealed class sealed_class{
        public void show(){
            Console.WriteLine("I am sealed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sealed_class obj = new sealed_class();
            obj.show();
        }
    }
}
