using System;
//c# use intefence instead of multiple inheritence
// multiple inheritence add more complexity with little benefit.
//suppose there is a method in two base class e.g calculate(), both are doing different calculation.
//what happen if user call calculate()
//Multiple inheritence cause slow execution


/* multiple inheritence is 

base 1          base 2

        derived

  */
namespace muliple_intheritence
{
    interface baseclass1
    {
    int calculate();
    }
    interface baseclass2{
        int calculate();  
        
    }
    class base1:baseclass1{
       public int calculate(){
            int x=5;
            return x;
        }

    }

    class base2:baseclass2{
        public int calculate(){
            int y=6;
            return y;
        }

    }
    public class derive:baseclass1,baseclass2
    {
       base1 obj1=new base1();
       base2 obj2=new base2();
       public int calculate(){
           int s1=obj1.calculate();
           int s2=obj2.calculate();
           Console.WriteLine("value:"+s1+","+s2);
           return 0;
       }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            derive obj=new derive();
            obj.calculate();
        }
    }
}
