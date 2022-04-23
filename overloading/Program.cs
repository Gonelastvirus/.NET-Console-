using System;
//method overloading in c#
namespace overloading
{
    class Program
    {
    public void show(){
        Console.WriteLine("Hello");
    } 
    public void show(int a){
        Console.WriteLine("Hello"+a);
    }
        static void Main(string[] args)
        {
            Program obj=new Program();
            obj.show();
            obj.show(5);
        }
    }
}
