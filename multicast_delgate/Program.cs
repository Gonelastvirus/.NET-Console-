using System;

namespace multicast_delgate
{
    public class test{
        public delegate int calculate(int a, int b);//declaration
        public int add(int x, int y){
            Console.WriteLine("Sum is : "+(x+y));
            return 0;
        }
        public int sub(int x, int y){
            Console.WriteLine("Sub is :"+(x-y));
            return 0;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            test obj = new test();
            //Instantiation
            test.calculate a1=null;
            a1+= new test.calculate(obj.add);
            a1+= new test.calculate(obj.sub);
            a1(5,4);
        }
    }
}
