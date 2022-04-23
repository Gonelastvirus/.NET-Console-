using System;

namespace structure
{
    struct node
    {
        int x;
        int y;
        public void set(int i, int j){
            x=i;
            y=j;
        }
        public void sum()
        {
            int sum=x+y;
            Console.WriteLine(sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          node obj=new node();
          obj.set(5,4);
          obj.sum();
        }
    }
}
