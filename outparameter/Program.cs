using System;
//out is same as ref parameter,that doesnt create memory allocation
//usually return keyword return single value from method
//see the output using out keyword it can return multiple value
namespace outparameter
{
    class Program
    {
        public static void calculate(int a,out int area, out int cube){
           area=a*a;
           cube=a*a*a;
        }
        static void Main(string[] args)
        {
            int area,cube;
            Program.calculate(5,out area,out cube);
            Console.WriteLine(area+","+cube);

        }
    }
}
