using System;

namespace refrence_type_parameter
{
    class Program
    {
        public static int calculate(ref int a){ // it must be static
            a=a*a;//perform the operation 
            return 0;
        }
        static void Main(string[] args)
        {
            int x=5;
            Program.calculate(ref x);// referene of variable is pass 
            Console.WriteLine(x);
            //before:x=5 After:25
        }
    }
}
