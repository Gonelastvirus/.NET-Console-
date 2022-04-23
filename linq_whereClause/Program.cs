using System;
using System.Collections.Generic;
using System.Linq;
namespace linq_whereClause
{
    class test{
        public void where(List<string> sp)
        {
            //filter data
            var result=from s in sp 
            where s.Contains("dai")
            select s;

            //display
            foreach (String a in result){
                Console.WriteLine(a);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           List<string> productlist = new List<string>(){
               "Manzil",
               "Subesh",
               "Suprav",
               "Dhakal dai",
               "Mote dai",
               "Ramesh uncle ko xoro"
           };
           test obj = new test();
           obj.where(productlist);

        }
    }
}
