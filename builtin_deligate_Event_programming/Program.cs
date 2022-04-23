using System;

namespace builtin_deligate_Event_programming
{
    public class test{
        public event EventHandler<EventArgs> e_sum;
        public int sum(int x, int y){
            Console.WriteLine("sum : "+(x+y));
            e_sum(this, EventArgs.Empty);// raised event
            return 0;
        }
        
    }

    class Program
    {
        //Delegate call this method when event raised
        static void EventMessage(object sender, EventArgs e){
            Console.WriteLine("Sum is calculated");
        }
        static void Main(string[] args)
        {
           test obj= new test();
           obj.e_sum+=EventMessage;
           obj.sum(5,4);
        }
    }
}
