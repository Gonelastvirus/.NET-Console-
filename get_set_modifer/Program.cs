using System;
/* 
the get method used for retrieving the value from private field
whereas set method used for storing the value in private variables.
*/
namespace get_set_modifer
{

    class A{
        private int n;
        public int show{
            get { return n;}
            set { n=value;}
        }
        public void print(){
            Console.WriteLine(n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.show=5;//dont confuse the show method uses get to retive value and set to store so its not obj.n=5 but obj.show=5
            obj.print();
        }
    }
}
